using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautifulDataVisualizer
{
    public partial class ItemPanel : UserControl
    {
        delegate void AddGridLineDelegate(StockData data);               
        private FileDataFeed Feed;
        private GridLines gridLines = new GridLines();       
        private Thread ReadDataFunc_Task = null;
        private string filePath = null;
        private GraphControl graphControl;
        private int itemId;

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public ItemPanel(FileDataFeed fileData, string _filePath, GraphControl _control)
        {
            filePath = _filePath;
            Feed = fileData;
            graphControl = _control;            
            InitializeComponent();
        }        
        private void ReadDataFunc()
        {
            Feed.OpenFeed();

            var putToSleep = new Action<int>(ti =>
            {
                try
                {
                    System.Threading.Thread.Sleep(ti);
                }
                catch (Exception e)
                {
                    if (e.GetType() != typeof(ThreadInterruptedException))
                        throw e;
                }
            });            

            while (Feed.HasData().HasValue && Feed.HasData().Value)
            {
                if (graphControl.GetPause(filePath)) putToSleep(Timeout.Infinite);

                StockData data = null;
                if (!Feed.ConsumeData(ref data))
                    break;
                AddGridLine(data);                
                graphControl.FullGraph(data);
                putToSleep(graphControl.DelayBetweenStockPrintsMiliSecond(filePath));
            }
        }
        private void AddGridLine(StockData data)
        {
            if (dgvData.InvokeRequired)
            {
                AddGridLineDelegate func = new AddGridLineDelegate(AddGridLine);
                Invoke(func, new object[] { data });
            }
            else
            {
                gridLines.Add(new GridLine { Low = data.StockPriceLow, High = data.StockPriceHigh, Volume = data.stockVolume, rawData = data });
            }
        }        
        private void ItemPanel_Load(object sender, EventArgs e)
        {            
            filePath = $"{filePath}_{itemId}";
            grbItem.Text = filePath;
            dgvData.DataSource = gridLines;
            dgvData.CellFormatting += dgvData_CellFormatting;
            ReadDataFunc_Task = new Thread(ReadDataFunc);
            graphControl.RememberItemThread(ReadDataFunc_Task, filePath);
            ReadDataFunc_Task.Start();
        }
        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCell cell = this.dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex];
            StockData data = gridLines[e.RowIndex].rawData;
            cell.ToolTipText = string.Format("Open:{0} Close:{1} adj:{2}", data.stockPriceOpen, data.StockPriceClose, data.StockPriceAdjClose);
        }
        
    }
}
