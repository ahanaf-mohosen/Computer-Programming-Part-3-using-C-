using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merge_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 5, 7, 2, 9, 1, 8 };
            int size = arr.Count;

            Console.Write("Original array: ");
            Print(arr);

            MergeSort(arr, 0, size - 1); // Correct range
            Console.Write("\nSorted array: ");
            Print(arr);
        }

        static void MergeSort(List<int> arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int mid = left + (right - left) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }

        static void Merge(List<int> arr, int left, int mid, int right)
        {
            int sizeLeft = mid - left + 1;
            int sizeRight = right - mid;

            List<int> L = new List<int>(sizeLeft);
            List<int> R = new List<int>(sizeRight);

            // Copy data to temporary arrays
            for (int i = 0; i < sizeLeft; i++)
            {
                L.Add(arr[left + i]);
            }
            for (int i = 0; i < sizeRight; i++)
            {
                R.Add(arr[mid + 1 + i]);
            }

            int indexL = 0, indexR = 0, indexA = left;

            // Merge the temporary arrays back into the original array
            while (indexL < sizeLeft && indexR < sizeRight)
            {
                if (L[indexL] <= R[indexR])
                {
                    arr[indexA] = L[indexL];
                    indexL++;
                }
                else
                {
                    arr[indexA] = R[indexR];
                    indexR++;
                }
                indexA++;
            }

            // Copy remaining elements from L[], if any
            while (indexL < sizeLeft)
            {
                arr[indexA] = L[indexL];
                indexA++;
                indexL++;
            }

            // Copy remaining elements from R[], if any
            while (indexR < sizeRight)
            {
                arr[indexA] = R[indexR];
                indexA++;
                indexR++;
            }
        }

        static void Print(List<int> arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
