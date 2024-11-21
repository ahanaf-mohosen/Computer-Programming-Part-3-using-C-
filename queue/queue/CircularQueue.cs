using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    internal class CircularQueue
    {
        private Queue<int> queue;
        private int maxSize;

        public CircularQueue(int size)
        {
            maxSize = size;
            queue = new Queue<int>(size);
        }

        // Enqueue method with circular behavior
        public void Enqueue(int item)
        {
            if (queue.Count == maxSize)
            {
                Console.WriteLine("Queue is full!");
            }
            else
            {
                queue.Enqueue(item);
            }
        }

        // Dequeue method
        public int Dequeue()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is empty!");
                return -1;
            }
            return queue.Dequeue();
        }

        // Method to get the current size of the queue
        public int Size()
        {
            return queue.Count;
        }
    }
}

