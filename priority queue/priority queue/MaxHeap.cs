using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace priority_queue
{
    internal class MaxHeap
    {
        private int[] heap;
        private int size;

        public MaxHeap(int capacity)
        {
            heap = new int[capacity + 1]; // index 0 is unused
            size = 0;
        }

        private int Left(int index) => 2 * index;
        private int Right(int index) => 2 * index + 1;
        private int Parent(int index) => index / 2;

        public bool IsMaxHeap()
        {
            for (int i = size; i >= 1; i--)
            {
                int p = Parent(i);
                if (p > 0 && heap[p] < heap[i])
                {
                    return false;
                }
            }
            return true;
        }

        private void MaxHeapify(int index)
        {
            int l = Left(index);
            int r = Right(index);
            int largest = index;

            if (l <= size && heap[l] > heap[largest])
            {
                largest = l;
            }

            if (r <= size && heap[r] > heap[largest])
            {
                largest = r;
            }

            if (largest != index)
            {
                Swap(index, largest);
                MaxHeapify(largest);
            }
        }

        private void Swap(int i, int j)
        {
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        public void BuildMaxHeap(int[] array)
        {
            size = array.Length;
            array.CopyTo(heap, 1);
            for (int i = size / 2; i >= 1; i--)
            {
                MaxHeapify(i);
            }
        }

        public void PrintHeap()
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write(heap[i] + " ");
            }
            Console.WriteLine();
        }

        public int GetMaximum()
        {
            return heap[1];
        }

        public int ExtractMax()
        {
            int max = heap[1];
            heap[1] = heap[size];
            size--;
            MaxHeapify(1);
            return max;
        }

        public void InsertNode(int node)
        {
            size++;
            heap[size] = node;

            int i = size;
            while (i > 1 && heap[i] > heap[Parent(i)])
            {
                Swap(i, Parent(i));
                i = Parent(i);
            }
        }

        public void HeapSort()
        {
            int originalSize = size;
            for (int i = size; i >= 2; i--)
            {
                Swap(1, i);
                size--;
                MaxHeapify(1);
            }
            size = originalSize;
        }
    }
}

