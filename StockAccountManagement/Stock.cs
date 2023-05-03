using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    class Stock
    {
        public string Name { get; set; }
        public int NumOfShares { get; set; }
        public double Price { get; set; }

        public double CalculateValue()
        {
            return NumOfShares * Price;
        }
    }
}