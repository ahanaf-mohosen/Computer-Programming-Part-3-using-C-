using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list_update
{
    internal class LinkedList
    {
        private Node head;

        public void Prepend(int item)
        {
            var newNode = new Node(item) { Next = head };
            head = newNode;
        }

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

        public void Remove(int item)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            if (head.Data == item)
            {
                head = head.Next;
                return;
            }

            Node current = head, prev = null;
            while (current != null && current.Data != item)
            {
                prev = current;
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine($"Node with value {item} not found.");
                return;
            }

            prev.Next = current.Next;
        }

        public void InsertAfter(int target, int item)
        {
            var current = head;
            while (current != null && current.Data != target)
            {
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine($"Node with value {target} not found.");
                return;
            }

            var newNode = new Node(item) { Next = current.Next };
            current.Next = newNode;
        }

        public void PrintList()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            var current = head;
            while (current != null)
            {
                Console.WriteLine($"data: {current.Data}");
                current = current.Next;
            }
        }

        public void FreeList()
        {
            head = null; // Garbage collector will handle the rest in C#.
        }
    }
}
