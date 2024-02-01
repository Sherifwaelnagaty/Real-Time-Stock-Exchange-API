using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Orders
    {
        public string StockSymbol { get; set; }
        public string OrderType { get; set; }
        public int Quantity { get; set; }

    }
}
