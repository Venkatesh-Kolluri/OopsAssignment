using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    class StockPortfolio
    {
        public List<Stock> Stocks { get; set; }

        public double CalculateTotalValue()
        {
            double totalValue = 0;
            foreach (Stock stock in Stocks)
            {
                totalValue += stock.CalculateValue();
            }
            return totalValue;
        }
        public void PrintStocksReport()
        {
            Console.WriteLine("Stock Report:\n");
            foreach (Stock stock in Stocks)
            {
                double stockValue = stock.CalculateValue();
                Console.WriteLine("Stock Name: {0}", stock.Name);
                Console.WriteLine("Number of Shares: {0}", stock.NumOfShares);
                Console.WriteLine("Share Price: {0} ", stock.Price);
                Console.WriteLine("Total Value: {0}\n", stockValue);
            }
            double totalValue = CalculateTotalValue();
            Console.WriteLine("Total Portfolio Value: {0} ", totalValue+ " Rupees");
        }
    }

   
}
