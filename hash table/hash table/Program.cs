using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hash_table
{
    internal class Program
    {
        // Dictionary to store keys and their corresponding list of values
        static Dictionary<int, List<int>> hashTable = new Dictionary<int, List<int>>();
        static void Main(string[] args)
        {
            int choice, key, data;
            int continueChoice;

            do
            {
                Console.WriteLine("\n1. Insert item in the Hash Table");
                Console.WriteLine("2. Remove item from the Hash Table");
                Console.WriteLine("3. Check the size of the Hash Table");
                Console.WriteLine("4. Display the Hash Table");
                Console.Write("\nPlease enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter key: ");
                        key = int.Parse(Console.ReadLine());
                        Console.Write("Enter data: ");
                        data = int.Parse(Console.ReadLine());
                        Insert(key, data);
                        break;

                    case 2:
                        Console.Write("Enter the key to delete: ");
                        key = int.Parse(Console.ReadLine());
                        RemoveElement(key);
                        break;

                    case 3:
                        Console.WriteLine($"Size of Hash Table is: {SizeOfHashTable()}");
                        break;

                    case 4:
                        Display();
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }

                Console.Write("\nDo you want to continue? (press 1 for yes): ");
                continueChoice = int.Parse(Console.ReadLine());

            } while (continueChoice == 1);
        }

        // Function to insert a key and its value into the hash table
        static void Insert(int key, int data)
        {
            if (hashTable.ContainsKey(key))
            {
                hashTable[key].Add(data); // Add new value to the list of values for the existing key
                Console.WriteLine($"\nKey ({key}) has been updated with a new value");
            }
            else
            {
                hashTable[key] = new List<int> { data }; // Create a new list for the key and add the data
                Console.WriteLine($"\nKey ({key}) has been inserted");
            }
        }

        // Function to remove a key from the hash table
        static void RemoveElement(int key)
        {
            if (hashTable.ContainsKey(key))
            {
                hashTable.Remove(key); // Remove the key and its associated values
                Console.WriteLine($"\nKey ({key}) has been removed");
            }
            else
            {
                Console.WriteLine("\nThis key does not exist");
            }
        }

        // Function to display the hash table
        static void Display()
        {
            foreach (var entry in hashTable)
            {
                Console.Write($"Key ({entry.Key}): ");
                foreach (var value in entry.Value)
                {
                    Console.Write($"[data: {value}] ");
                }
                Console.WriteLine();
            }
        }

        // Function to return the size of the hash table
        static int SizeOfHashTable()
        {
            return hashTable.Count;
        }
    }
}

