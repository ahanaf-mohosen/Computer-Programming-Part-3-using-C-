using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hash_table
{
    internal class HashTable
    {
        private KeyNode[] array;
        public int Capacity { get; private set; }
        public int Size { get; private set; }

        public HashTable(int capacity)
        {
            Capacity = capacity;
            Size = 0;
            array = new KeyNode[capacity];
        }

        private int HashFunction(int key)
        {
            return key % Capacity;
        }

        public void Insert(int key, int data)
        {
            int index = HashFunction(key);
            KeyNode current = array[index];

            // Check if the key already exists
            while (current != null)
            {
                if (current.Key == key)
                {
                    // Add the value to the values list
                    ValueNode newValue = new ValueNode(data);
                    newValue.Next = current.Values;
                    current.Values = newValue;
                    Console.WriteLine($"\nKey ({key}) has been updated with a new value");
                    return;
                }
                current = current.Next;
            }

            // If key does not exist, create a new key node
            KeyNode newKeyNode = new KeyNode(key);
            ValueNode newValueNode = new ValueNode(data);
            newKeyNode.Values = newValueNode;

            // Insert the new key node at the head of the list for this index
            newKeyNode.Next = array[index];
            array[index] = newKeyNode;
            Size++;
            Console.WriteLine($"\nKey ({key}) has been inserted");
        }

        public void Remove(int key)
        {
            int index = HashFunction(key);
            KeyNode current = array[index];
            KeyNode prev = null;

            // Traverse the list to find the key
            while (current != null)
            {
                if (current.Key == key)
                {
                    // Remove the key node
                    if (prev != null)
                    {
                        prev.Next = current.Next;
                    }
                    else
                    {
                        array[index] = current.Next;
                    }

                    // Free all value nodes
                    ValueNode valueCurrent = current.Values;
                    while (valueCurrent != null)
                    {
                        valueCurrent = valueCurrent.Next;
                    }

                    Size--;
                    Console.WriteLine($"\nKey ({key}) has been removed");
                    return;
                }
                prev = current;
                current = current.Next;
            }

            Console.WriteLine("\nThis key does not exist");
        }

        public void Display()
        {
            for (int i = 0; i < Capacity; i++)
            {
                Console.Write($"\narray[{i}]: ");
                KeyNode current = array[i];
                while (current != null)
                {
                    Console.Write($"Key ({current.Key}): ");
                    ValueNode valueCurrent = current.Values;
                    while (valueCurrent != null)
                    {
                        Console.Write($"[data: {valueCurrent.Data}] ");
                        valueCurrent = valueCurrent.Next;
                    }
                    Console.Write(" -> ");
                    current = current.Next;
                }
            }
            Console.WriteLine();
        }

        public int GetSize()
        {
            return Size;
        }
    }
}
