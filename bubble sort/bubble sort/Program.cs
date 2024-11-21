using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 2, 1, 8, 6, 4 };
            int size = arr.Length;

            Console.Write("Before Sort = ");
            Print(arr, size);

            if (IsSorted(arr, size))
            {
                Console.WriteLine("\nArray is already sorted.");
            }
            else
            {
                BubbleSort(arr, size);
                Console.Write("\nAfter Sort = ");
                Print(arr, size);
            }
        }

        static void BubbleSort(int[] arr, int size)
        {
            int temp;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void Print(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static bool IsSorted(int[] arr, int size)
        {
            for (int i = 0; i < size - 1; i++)
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
