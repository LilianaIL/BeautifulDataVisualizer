using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using System.Linq;

namespace BeautifulDataVisualizer
{
    public partial class GraphControl : UserControl
    {        
        delegate void TestDelegate(StockData data);
        delegate void Test2Delegate(string data);       
        private Dictionary<string, Thread> itemsThreads;       
        private Dictionary<string, bool> pause;
        private Dictionary<string, int> hbarValue;
        private Dictionary<string, int> delayBetweenStockPrintsMiliSecond;

        public GraphControl()
        {            
            InitializeComponent();
        }

        public bool GetPause(string itemName)
        {
           return pause[itemName]; 
        }        
        public int DelayBetweenStockPrintsMiliSecond(string itemName)
        {
             return delayBetweenStockPrintsMiliSecond[itemName];             
        }
        public void FullGraph(StockData data)
        {
            if (chartGeneral.InvokeRequired)
            {
                TestDelegate func = new TestDelegate(FullGraph);
                Invoke(func, new object[] { data });
            }
            else
            {               
                var seria = chartGeneral.Series.FindByName(data.StockSymbol);

                if (seria == null)
                {
                    seria = new Series(data.StockSymbol);                   
                    seria.BorderWidth = 3;
                    seria.ChartType = SeriesChartType.Line;
                    seria.MarkerStyle = MarkerStyle.Circle;
                    seria.MarkerSize = 8;                    
                    Legend legend = new Legend(data.StockSymbol);
                    chartGeneral.Legends.Add(legend);                    
                    seria.IsVisibleInLegend = true;
                    chartGeneral.Series.Add(seria);                    
                }
                
                seria.Points.AddXY(data.Date, data.stockVolume);                              
                seria.Points.LastOrDefault().ToolTip= $"Date: {data.Date.ToShortDateString()}\\nOpen:{data.stockPriceOpen}\\nClose:{data.StockPriceClose}\\nadj:{data.StockPriceAdjClose}\\nLow: {data.StockPriceLow}\\nHigh: {data.StockPriceHigh}\\nVolume: {data.stockVolume}";               
            }
        }
        public void RememberItemThread(Thread thread, string itemName)
        {            
            itemsThreads.Add(itemName, thread);
            AddComboItem(itemName);
        }
        public void SetActionsControlVisible()
        {
            tlpActions.Visible = true;
        }

        private void AddComboItem(string itemName)
        {           
            cmbFiles.Items.Add(itemName);            
            pause.Add(itemName, false);
            delayBetweenStockPrintsMiliSecond.Add(itemName, 1000);
            hbarValue.Add(itemName, 50);
            if (cmbFiles.Items.Count == 1)
            {
                cmbFiles.SelectedItem = itemName;                
            }
        }               
        private void GraphControl_Load(object sender, EventArgs e)
        {
            itemsThreads = new Dictionary<string, Thread>();
            btnAction.Click += btnAction_Click;
            cmbFiles.SelectedIndexChanged += cmbFiles_SelectedIndexChanged;
            pause = new Dictionary<string, bool>();
            delayBetweenStockPrintsMiliSecond = new Dictionary<string, int>();
            hbarValue = new Dictionary<string, int>();
        }
        private void btnAction_Click(object sender, System.EventArgs e)
        {
            var tableName = cmbFiles.SelectedItem.ToString();            
            pause[tableName] = !pause[tableName];
            btnAction.Text = (pause[tableName] ? "Play" : "Pause");             
            if(!pause[tableName]) itemsThreads[tableName].Interrupt();
        }
        private void cmbFiles_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var tableName = cmbFiles.SelectedItem.ToString();
            btnAction.Text = (pause[tableName] ? "Play" : "Pause");
            scbSpeed.Value = hbarValue[tableName];
        }
        private void scbSpeed_Scroll(object sender, ScrollEventArgs e)
        {
            var tableName = cmbFiles.SelectedItem.ToString();
            HScrollBar hbar = (HScrollBar)sender;
            hbarValue[tableName]=hbar.Value;
            if (hbar.Value <= 50)
            {
                delayBetweenStockPrintsMiliSecond[tableName] = (int)((Convert.ToDouble(hbar.Value) / 50) * 1000);
            }
            else
                delayBetweenStockPrintsMiliSecond[tableName] = (int)((Convert.ToDouble(hbar.Value - 50) / 50) * (10000 - 1000) + 1000);
        }
    }
}
