using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    internal class LinkedList
    {
        private Node head;

        // Prepend a new node at the beginning
        public void Prepend(int item)
        {
            var newNode = new Node(item) { Next = head };
            head = newNode;
        }

        // Append a new node at the end
        public void Append(int item)
        {
            var newNode = new Node(item);
            if (head == null)
            {
                head = newNode;
                return;
            }
            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        // Print the list contents
        public void PrintList()
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            var current = head;
            while (current != null)
            {
                Console.WriteLine($"Data: {current.Data}");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
