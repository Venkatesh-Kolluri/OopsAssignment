using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of stocks:");
            int numStocks = int.Parse(Console.ReadLine());

            StockPortfolio portfolio = new StockPortfolio();
            portfolio.Stocks = new List<Stock>();

            for (int i = 1; i <= numStocks; i++)
            {
                Console.WriteLine("Enter the details for Stock: ", i);
                Console.Write("Stock Name: ");
                string name = Console.ReadLine();
                Console.Write("Number of Shares: ");
                int numOfShares = int.Parse(Console.ReadLine());
                Console.Write("Share Price in Rupees: ");
                double price = double.Parse(Console.ReadLine());

                Stock stock = new Stock();
                stock.Name = name;
                stock.NumOfShares = numOfShares;
                stock.Price = price;

                portfolio.Stocks.Add(stock);
            }

            portfolio.PrintStocksReport();
        }
    }
}
