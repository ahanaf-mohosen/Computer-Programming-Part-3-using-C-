using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search_tree
{
    internal class Node
    {
        public int Data;
        public Node Parent;
        public Node Left;
        public Node Right;

        public Node(int item)
        {
            Data = item;
            Left = null;
            Right = null;
            Parent = null;
        }
    }
}
