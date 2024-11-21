using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    internal class TreeNode
    {
        public int Data;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int item)
        {
            Data = item;
            Left = null;
            Right = null;
        }
    }
}
