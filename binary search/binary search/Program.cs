using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int search = 10;

            // Using built-in BinarySearch method
            int result = Array.BinarySearch(arr, search);

            if (result < 0)
            {
                Console.WriteLine("Element is not present in array");
            }
            else
            {
                Console.WriteLine($"Element is present in array at position {result}");
            }
        }
    }
}
