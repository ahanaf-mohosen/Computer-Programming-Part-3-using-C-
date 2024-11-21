using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList();

            // Create initial node with value 10
            var initialNode = new Node(10);
            list.Append(10);  // Adding it to the list

            list.PrintList(); // Print the list

            // Prepend nodes to the list
            list.Prepend(20);
            list.Prepend(5);
            list.PrintList();

            // Append nodes to the list
            list.Append(30);
            list.Append(40);
            list.PrintList();
        }
    }
}
