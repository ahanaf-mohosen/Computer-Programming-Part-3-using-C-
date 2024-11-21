using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the binary tree
            TreeNode root = CreateTree();

            // Perform traversals
            Console.Write("PreOrder: ");
            PreOrder(root);
            Console.WriteLine();

            Console.Write("InOrder: ");
            InOrder(root);
            Console.WriteLine();

            Console.Write("PostOrder: ");
            PostOrder(root);
            Console.WriteLine();
        }
        public static TreeNode CreateTree()
        {
            // Create nodes
            TreeNode two = new TreeNode(2);
            TreeNode seven = new TreeNode(7);
            TreeNode nine = new TreeNode(9);
            two.Left = seven;
            two.Right = nine;

            TreeNode one = new TreeNode(1);
            TreeNode six = new TreeNode(6);
            TreeNode eight = new TreeNode(8);
            seven.Left = one;
            seven.Right = six;
            nine.Left = eight;

            TreeNode five = new TreeNode(5);
            TreeNode ten = new TreeNode(10);
            TreeNode three = new TreeNode(3);
            TreeNode four = new TreeNode(4);
            six.Left = five;
            six.Right = ten;
            eight.Left = three;
            eight.Right = four;

            return two;  // Return the root node (2)
        }

        // Pre-order traversal (Root, Left, Right)
        public static void PreOrder(TreeNode node)
        {
            if (node != null)
            {
                Console.Write(node.Data + " ");
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }

        // Post-order traversal (Left, Right, Root)
        public static void PostOrder(TreeNode node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                Console.Write(node.Data + " ");
            }
        }

        // In-order traversal (Left, Root, Right)
        public static void InOrder(TreeNode node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                Console.Write(node.Data + " ");
                InOrder(node.Right);
            }

        }
    }
}
