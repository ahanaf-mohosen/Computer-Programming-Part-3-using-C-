using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linear_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 2, 3, 4, 10, 40 };
            int search = 10;

            int result = LinearSearch(arr, search);

            Console.WriteLine(result == -1
                ? "Element is not present in array"
                : $"Element is present in array at position {result}");
        }

        static int LinearSearch(List<int> arr, int search)
        {
            // Use LINQ for a concise search
            return arr.IndexOf(search);
        }
    }
}

