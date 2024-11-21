using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertion_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 4, 5, 2, 1, 8, 6, 4 };

            Console.Write("Before Sort = ");
            Print(arr);

            if (IsSorted(arr))
            {
                Console.WriteLine("\nArray is already sorted.");
            }
            else
            {
                InsertionSort(arr);
                Console.Write("\nAfter Sort = ");
                Print(arr);
            }
        }
        static void InsertionSort(List<int> arr)
        {
            for (int i = 1; i < arr.Count; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }

        // Print the elements of the list
        static void Print(List<int> arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        // Check if the list is already sorted
        static bool IsSorted(List<int> arr)
        {
            return arr.Zip(arr.Skip(1), (a, b) => a <= b).All(x => x);
        }
    }
}

