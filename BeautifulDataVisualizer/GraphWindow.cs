using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Threading;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

namespace BeautifulDataVisualizer
{
    public partial class GraphWindow : Form
    {        
        const int DelayBetweenStockPrintsMiliSecond = 1000;
        bool UseUIWindow = true;
        ItemPanel panel = null;
        delegate void SetTextCallback(ItemPanel panel);

        public GraphWindow()
        {
            InitializeComponent();
        }

        void AddItemPanel(ItemPanel panel)
        {           
            if (tlpContent.InvokeRequired)
            {                
                SetTextCallback d = new SetTextCallback(AddItemPanel);
                tlpContent.Invoke(d, new object[] { panel });
            }
            else
            {
                var rowCount = tlpContent.RowCount;

                if (tlpContent.Controls.Count>0)
                {
                    tlpContent.RowCount = rowCount + 1;
                    tlpContent.RowStyles.Add(new RowStyle(SizeType.AutoSize, 50F));
                }

                panel.ItemId = rowCount;
                tlpContent.Controls.Add(panel, 1, rowCount);                   
            }
        }        
        void PrintDataFunc(string fileName, FileDataFeed fileData)
        {            
            if (UseUIWindow == true)
            {
                panel = new ItemPanel(fileData, fileName, graph) { 
                    Dock= DockStyle.Fill
                };                

                var panelThread = new Thread(() =>
                {
                    AddItemPanel(panel);
                });
               
            panelThread.SetApartmentState(ApartmentState.STA);
            panelThread.Start();
            }            
        }        
        void btnUpload_Click(object sender, EventArgs e)
        {            
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {                               
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    filePath = openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf('\\')+1);                   
                    FileDataFeed fileData = new FileDataFeed(filePath);
                    ConcurrentQueue<StockData> AAPLDataQueue = new ConcurrentQueue<StockData>();
                    graph.SetActionsControlVisible();
                    var thread = new Thread(() =>
                    {
                        PrintDataFunc(filePath, fileData);
                    });
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();                    
                }
                
            }

 
        }
        
    }
}
