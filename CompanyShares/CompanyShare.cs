using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyShares
{
    class CompanyShare
    {
        public string CompanyName;
        public int NumberOfShares;
     
        public CompanyShare(string companyName, int numOfShares)
        {
            CompanyName = companyName;
            NumberOfShares = numOfShares;
            
        }
    }

    class LinkedListNode
    {
        public CompanyShare Value;
        public LinkedListNode Next;

        public LinkedListNode(CompanyShare value)
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
        public void Add(CompanyShare value)
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
                Console.WriteLine("CompanyName: {0}, Number of Shares: {1}",
                    currentNode.Value.CompanyName, currentNode.Value.NumberOfShares);
                currentNode = currentNode.Next;
            }
        }
    }
}
