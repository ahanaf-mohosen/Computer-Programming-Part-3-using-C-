using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hash_table
{
    internal class KeyNode
    {
        public int Key { get; set; }
        public ValueNode Values { get; set; }
        public KeyNode Next { get; set; }

        public KeyNode(int key)
        {
            Key = key;
            Values = null;
            Next = null;
        }
    }
}
