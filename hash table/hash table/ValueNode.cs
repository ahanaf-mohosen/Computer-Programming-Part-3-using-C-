using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hash_table
{
    internal class ValueNode
    {
        public int Data { get; set; }
        public ValueNode Next { get; set; }

        public ValueNode(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
