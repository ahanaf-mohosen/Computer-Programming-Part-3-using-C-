using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] A = { 1, 5, 6, 3, 5, 8, 7, 2, 9 };

            Console.Write("Original array: ");
            PrintArray(A);

            QuickSortArray(A, 0, A.Length - 1);

            Console.Write("Sorted array: ");
            PrintArray(A);
        }


            // Partition function for quicksort
    public static int Partition(int[] A, int low, int high)
        {
            int pivot = A[high];
            int i = low - 1;
            int temp;

            for (int j = low; j < high; j++)
            {
                if (A[j] <= pivot)
                {
                    i++;
                    temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }
            temp = A[high];
            A[high] = A[i + 1];
            A[i + 1] = temp;

            return (i + 1);
        }

        // QuickSort function
        public static void QuickSortArray(int[] A, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(A, low, high);
                QuickSortArray(A, low, p - 1);
                QuickSortArray(A, p + 1, high);
            }
        }

        // Function to print the array
        public static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}

