using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list_update
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList();
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Prepend");
                Console.WriteLine("2. Append");
                Console.WriteLine("3. Print List");
                Console.WriteLine("4. Remove Node");
                Console.WriteLine("5. Insert After Node");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine() ?? "0");

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the value to prepend: ");
                        int prependValue = int.Parse(Console.ReadLine() ?? "0");
                        list.Prepend(prependValue);
                        break;
                    case 2:
                        Console.Write("Enter the value to append: ");
                        int appendValue = int.Parse(Console.ReadLine() ?? "0");
                        list.Append(appendValue);
                        break;
                    case 3:
                        Console.WriteLine("Linked list contents:");
                        list.PrintList();
                        break;
                    case 4:
                        Console.Write("Enter the value to remove: ");
                        int removeValue = int.Parse(Console.ReadLine() ?? "0");
                        list.Remove(removeValue);
                        break;
                    case 5:
                        Console.Write("Enter the target value after which to insert: ");
                        int targetValue = int.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Enter the value to insert: ");
                        int insertValue = int.Parse(Console.ReadLine() ?? "0");
                        list.InsertAfter(targetValue, insertValue);
                        break;
                    case 6:
                        Console.WriteLine("Exiting program.");
                        list.FreeList();
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }
    }
}
