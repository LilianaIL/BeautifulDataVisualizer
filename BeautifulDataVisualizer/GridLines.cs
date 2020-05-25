using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulDataVisualizer
{
    public class GridLine
    {
        public double Low { get; set; }
        public double High { get; set; }
        public double Volume { get; set; }

        public StockData rawData;
    }

    public class GridLines : BindingList<GridLine>
    {
    }
}
