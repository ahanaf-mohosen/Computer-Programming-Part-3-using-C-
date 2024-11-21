using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubly_linked_list
{
    internal class Node
    {
        public int? Data;
        public Node Prev;
        public Node Next;

        public Node()
        {
            Data = null;
            Prev = null;
            Next = null;
        }
    }
}
