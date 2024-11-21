using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            Console.Write("Before Sort = ");
            PrintArray(arr);

            if (IsSorted(arr))
            {
                Console.WriteLine("\nArray is already sorted.");
            }
            else
            {
                SelectionSort(arr);
                Console.Write("\nAfter Sort = ");
                PrintArray(arr);
            }
        }

        // Function to perform selection sort
        public static void SelectionSort(int[] arr)
        {
            int minValue, temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                minValue = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minValue])
                    {
                        minValue = j;
                    }
                }
                if (minValue != i)
                {
                    temp = arr[i];
                    arr[i] = arr[minValue];
                    arr[minValue] = temp;
                }
            }
        }

        // Function to print the array
        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        // Function to check if the array is already sorted
        public static bool IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

