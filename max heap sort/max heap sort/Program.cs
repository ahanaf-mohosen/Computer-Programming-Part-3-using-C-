using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_heap_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> heap = new List<int> { 0, 19, 7, 12, 3, 5, 17, 10, 1, 2 };
            int size = heap.Count - 1;

            if (!IsMaxHeap(heap, size))
            {
                Console.WriteLine("This is not a max heap");
            }
            else
            {
                Console.WriteLine("This is a max heap");
            }

            Console.WriteLine("Initial Heap:");
            PrintHeap(heap, size);

            Console.WriteLine("After building max heap:");
            BuildMaxHeap(heap, size);
            PrintHeap(heap, size);

            Console.WriteLine("After sorting in descending order:");
            HeapSort(heap, size);
            PrintHeap(heap, size);
        }

        static int Left(int index) => 2 * index;
        static int Right(int index) => 2 * index + 1;
        static int Parent(int index) => index / 2;

        static bool IsMaxHeap(List<int> heap, int size)
        {
            for (int i = size; i >= 1; i--)
            {
                int p = Parent(i);
                if (heap[p] < heap[i])
                {
                    return false;
                }
            }
            return true;
        }

        static void MaxHeapify(List<int> heap, int size, int index)
        {
            int l = Left(index);
            int r = Right(index);
            int largest = index;

            if (l <= size && heap[l] > heap[index])
            {
                largest = l;
            }

            if (r <= size && heap[r] > heap[largest])
            {
                largest = r;
            }

            if (largest != index)
            {
                // Swap
                int temp = heap[index];
                heap[index] = heap[largest];
                heap[largest] = temp;

                MaxHeapify(heap, size, largest);
            }
        }

        static void PrintHeap(List<int> heap, int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write(heap[i] + " ");
            }
            Console.WriteLine();
        }

        static void BuildMaxHeap(List<int> heap, int size)
        {
            for (int i = size / 2; i >= 1; i--)
            {
                MaxHeapify(heap, size, i);
            }
        }

        static void HeapSort(List<int> heap, int size)
        {
            for (int i = size; i >= 1; i--)
            {
                // Swap the root (heap[1]) with the last element (heap[i])
                int temp = heap[1];
                heap[1] = heap[i];
                heap[i] = temp;

                // Reduce the size of the heap and restore the max heap property
                size--;
                MaxHeapify(heap, size, 1);
            }
        }
    }
}
