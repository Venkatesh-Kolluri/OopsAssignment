using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCardsExtended
{

    public class Player
    {
        private Node head;
        private int count;
        private class Node
        {
            public string data;
            public Node next;

            public Node(string data)
            {
                this.data = data;
                next = null;
            }
        }
        public Player()
        {
            head = null;
            count = 0;
        }
        public void AddCard(string card)
        {
            Node newNode = new Node(card);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
            count++;
        }
        public void SortCards()
        {
            for (Node i = head; i != null; i = i.next)
            {
                Node min = i;
                for (Node j = i.next; j != null; j = j.next)
                {
                    {
                        min = j;
                    }
                }
                string temp = i.data;
                i.data = min.data;
                min.data = temp;
            }
        }

        public void PrintCards()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }

}

