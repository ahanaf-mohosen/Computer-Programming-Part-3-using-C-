using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counting_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 2, 2, 8, 3, 3, 1 };

            Console.WriteLine("Original array: ");
            PrintArray(arr);

            // Calling Counting Sort
            CountingSort(arr);

            Console.WriteLine("\nSorted array: ");
            PrintArray(arr);
        }

        // Function to implement Counting Sort
        static void CountingSort(int[] arr)
        {
            // Find the maximum value in the array
            int max = arr[0];
            foreach (int item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            // Initialize count array
            int[] count = new int[max + 1];
            foreach (int item in arr)
            {
                count[item]++;
            }

            // Update the count array to store positions
            for (int i = 1; i <= max; i++)
            {
                count[i] += count[i - 1];
            }

            // Create an output array to store sorted elements
            int[] output = new int[arr.Length];
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
            }

            // Copy the sorted elements back into the original array
            Array.Copy(output, arr, arr.Length);
        }

        // Function to print the array
        static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
