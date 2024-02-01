using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Stock
    {
        public string StockSymbol { get; set; }
        public decimal Currentprices { get; set; }
        public DateTime Timestamps { get; set; }
    }
}
