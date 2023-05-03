using CompanyShareSymbol;

namespace CompanySharesTransactions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList linkedList = new LinkedList();

            linkedList.Add(new CompanyShares("Tata Consultancy Services", "TCS", 100, DateTime.Now));
            linkedList.Add(new CompanyShares("INDIAN ENERGY EXCHANGE", "IEX", 50, DateTime.Now));
            linkedList.Add(new CompanyShares("TATA POWER PLANT", "TATAPOWER", 10, DateTime.Now));


            linkedList.Print();

            LinkedListNode remove = linkedList.head.Next;
            linkedList.Remove(remove);

            linkedList.Print();

            Console.ReadKey();
        }
    }
}