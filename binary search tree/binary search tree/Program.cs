using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search_tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            // Test appending nodes
            Console.WriteLine("Appending 10, 20, 30 to the list:");
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            PrintList(list);

            // Test prepending a node (AddFirst)
            Console.WriteLine("Prepending 5 to the list:");
            list.AddFirst(5);
            PrintList(list);

            // Test removing the head node (5)
            Console.WriteLine("Removing the head node (5):");
            list.RemoveFirst();
            PrintList(list);

            // Test removing a middle node (20)
            Console.WriteLine("Removing a middle node (20):");
            var middleNode = list.Find(20); // Find the node with value 20
            if (middleNode != null)
            {
                list.Remove(middleNode);
            }
            PrintList(list);

            // Test removing the last node (30)
            Console.WriteLine("Removing the last node (30):");
            list.RemoveLast();
            PrintList(list);
        }

        // Function to print the list
        static void PrintList(LinkedList<int> list)
        {
            Console.Write("List: ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}


