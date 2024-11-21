using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int item;
            CircularQueue queue = new CircularQueue(5);

            // Enqueue items
            queue.Enqueue(10);
            Console.WriteLine($"Enqueue: 10, Current size: {queue.Size()}");
            queue.Enqueue(20);
            Console.WriteLine($"Enqueue: 20, Current size: {queue.Size()}");
            queue.Enqueue(30);
            Console.WriteLine($"Enqueue: 30, Current size: {queue.Size()}");

            // Dequeue items
            item = queue.Dequeue();
            Console.WriteLine($"Dequeued item: {item}");
            item = queue.Dequeue();
            Console.WriteLine($"Dequeued item: {item}");
            item = queue.Dequeue();
            Console.WriteLine($"Dequeued item: {item}");
            item = queue.Dequeue();
            Console.WriteLine($"Dequeued item: {item}");

            // Try to dequeue from an empty queue
            item = queue.Dequeue();
            Console.WriteLine($"Dequeued item: {item}");
        }
    }
}
