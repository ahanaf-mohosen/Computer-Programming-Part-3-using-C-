using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            // Push items onto the stack
            stack.Push(5);
            stack.Push(7);
            stack.Push(11);

            // Pop items from the stack
            try
            {
                int item = stack.Pop();
                Console.WriteLine("Popped item is " + item);

                item = stack.Pop();
                Console.WriteLine("Popped item is " + item);

                item = stack.Pop();
                Console.WriteLine("Popped item is " + item);

                // Attempting to pop from an empty stack
                item = stack.Pop(); // This will throw an exception if the stack is empty
                Console.WriteLine("Popped item is " + item);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Stack is empty!");
            }
        }
    }
}
