namespace CompanyShares
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
        
            linkedList.Add(new CompanyShare("HDFC BANK ", 100));
            linkedList.Add(new CompanyShare("AdaniSteel", 50));
            linkedList.Add(new CompanyShare("MRF", 10));
            linkedList.Add(new CompanyShare("IEX", 50));
          
            linkedList.Print();
         
            LinkedListNode remove = linkedList.head.Next;
            linkedList.Remove(remove);
 
            linkedList.Print();

            Console.ReadKey();
        }
    }

}
