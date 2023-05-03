using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyShareSymbol
{
    class CompanyShares
    {
        public string CompanyName;
        public string Symbol;
        public int NumberOfShares;
        public DateTime TransactionDateTime;

        public CompanyShares(string companyName, string symbol,int numOfShares,DateTime dateTime)
        {
            CompanyName = companyName;
            Symbol = symbol;
            NumberOfShares = numOfShares;
            TransactionDateTime = dateTime;

        }
    }

    class LinkedListNode
    {
        public CompanyShares Value;
        public LinkedListNode Next;

        public LinkedListNode(CompanyShares value)
        {
            Value = value;
            Next = null;
        }
    }

    class LinkedList
    {
        public LinkedListNode head;
        private LinkedListNode tail;


        public LinkedList()
        {
            head = null;
            tail = null;
        }
        public void Add(CompanyShares value)
        {
            LinkedListNode newNode = new LinkedListNode(value);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }

        public void Remove(LinkedListNode nodeToRemove)
        {
            LinkedListNode currentNode = head;
            LinkedListNode previousNode = null;

            while (currentNode != null)
            {
                if (currentNode == nodeToRemove)
                {
                    if (previousNode == null)
                    {
                        head = currentNode.Next;
                    }
                    else
                    {
                        previousNode.Next = currentNode.Next;
                    }

                    if (currentNode.Next == null)
                    {
                        tail = previousNode;
                    }

                    break;
                }

                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
        }

        public void Print()
        {
            LinkedListNode currentNode = head;

            while (currentNode != null)
            {
                Console.WriteLine("CompanyName: {0},Symbol: {1}, Number of Shares: {2},TransactionDateTime: {3}",
                    currentNode.Value.CompanyName,currentNode.Value.Symbol, currentNode.Value.NumberOfShares, currentNode.Value.TransactionDateTime);
                currentNode = currentNode.Next;
            }
        }
    }
}
