using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace priority_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> heap = new List<int> { 0, 19, 7, 12, 3, 5, 17, 10, 1, 2 }; // Index 0 is unused
            int max;

            // Check if it's a max heap
            if (IsMaxHeap(heap))
            {
                Console.WriteLine("This is a max heap");
            }
            else
            {
                Console.WriteLine("This is not a max heap");
            }

            // Print the initial heap
            Console.WriteLine("Initial Heap:");
            PrintHeap(heap);

            // Build max heap
            BuildMaxHeap(heap);
            Console.WriteLine("After building max heap:");
            PrintHeap(heap);

            // Get maximum element
            Console.WriteLine("Maximum element: " + GetMaximum(heap));

            // Extract maximum element
            int extractedMax = ExtractMax(heap);
            Console.WriteLine($"Extracted maximum element: {extractedMax}");
            Console.WriteLine("Heap after extraction:");
            PrintHeap(heap);

            // Insert a new element
            int newNode = 15;
            InsertNode(heap, newNode);
            Console.WriteLine($"Heap after inserting {newNode}:");
            PrintHeap(heap);

            // Sort the heap
            HeapSort(heap);
            Console.WriteLine("After sorting in descending order:");
            PrintHeap(heap);
        }

        static int Left(int index) => 2 * index;
        static int Right(int index) => 2 * index + 1;
        static int Parent(int index) => index / 2;

        // Check if the list is a max-heap
        static bool IsMaxHeap(List<int> heap)
        {
            int size = heap.Count - 1;
            for (int i = size / 2; i >= 1; i--)
            {
                int left = Left(i);
                int right = Right(i);
                if (left <= size && heap[left] > heap[i] || right <= size && heap[right] > heap[i])
                {
                    return false;
                }
            }
            return true;
        }

        // Max-heapify the heap
        static void MaxHeapify(List<int> heap, int size, int index)
        {
            int left = Left(index);
            int right = Right(index);
            int largest = index;
            if (left <= size && heap[left] > heap[largest]) largest = left;
            if (right <= size && heap[right] > heap[largest]) largest = right;

            if (largest != index)
            {
                Swap(heap, index, largest);
                MaxHeapify(heap, size, largest);
            }
        }

        // Swap two elements in the heap
        static void Swap(List<int> heap, int i, int j)
        {
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        // Print the heap
        static void PrintHeap(List<int> heap)
        {
            for (int i = 1; i < heap.Count; i++)
            {
                Console.Write(heap[i] + " ");
            }
            Console.WriteLine();
        }

        // Build a max-heap
        static void BuildMaxHeap(List<int> heap)
        {
            int size = heap.Count - 1;
            for (int i = size / 2; i >= 1; i--)
            {
                MaxHeapify(heap, size, i);
            }
        }

        // Get the maximum element (root of the heap)
        static int GetMaximum(List<int> heap)
        {
            return heap[1];
        }

        // Extract the maximum element (remove the root)
        static int ExtractMax(List<int> heap)
        {
            int size = heap.Count - 1;
            int max = heap[1];
            heap[1] = heap[size];
            heap.RemoveAt(size);
            MaxHeapify(heap, size - 1, 1);
            return max;
        }

        // Insert a new node
        static void InsertNode(List<int> heap, int node)
        {
            heap.Add(node);
            int i = heap.Count - 1;
            while (i > 1 && heap[i] > heap[Parent(i)])
            {
                Swap(heap, i, Parent(i));
                i = Parent(i);
            }
        }

        // Heap Sort (descending order)
        static void HeapSort(List<int> heap)
        {
            int size = heap.Count - 1;
            for (int i = size; i >= 2; i--)
            {
                Swap(heap, 1, i);
                heap.RemoveAt(i);
                MaxHeapify(heap, heap.Count - 1, 1);
            }
        }
    }
}
