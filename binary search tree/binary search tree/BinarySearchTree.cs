using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search_tree
{
    internal class BinarySearchTree
    {
        public static Node CreateBST()
        {
            Node root = new Node(10);
            int[] values = { 5, 17, 3, 7, 12, 19, 1, 4 };

            foreach (var value in values)
            {
                Node node = new Node(value);
                root = BSTInsert(root, node);
            }

            return root;
        }

        public static Node BSTInsert(Node root, Node node)
        {
            Node parentNode = null;
            Node currentNode = root;

            while (currentNode != null)
            {
                parentNode = currentNode;
                if (node.Data < currentNode.Data)
                {
                    currentNode = currentNode.Left;
                }
                else
                {
                    currentNode = currentNode.Right;
                }
            }

            if (parentNode == null)
            {
                root = node;
            }
            else if (node.Data < parentNode.Data)
            {
                AddLeftChild(parentNode, node);
            }
            else
            {
                AddRightChild(parentNode, node);
            }

            return root;
        }

        public static void AddLeftChild(Node parent, Node child)
        {
            parent.Left = child;
            if (child != null)
            {
                child.Parent = parent;
            }
        }

        public static void AddRightChild(Node parent, Node child)
        {
            parent.Right = child;
            if (child != null)
            {
                child.Parent = parent;
            }
        }

        public static Node BSTSearch(Node root, int item)
        {
            Node node = root;
            while (node != null)
            {
                if (node.Data == item)
                {
                    return node;
                }
                node = item < node.Data ? node.Left : node.Right;
            }
            return null;
        }

        public static Node BSTMinimum(Node root)
        {
            Node node = root;
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        public static Node BSTMaximum(Node root)
        {
            Node node = root;
            while (node.Right != null)
            {
                node = node.Right;
            }
            return node;
        }

        public static Node BSTTransplant(Node root, Node currentNode, Node newNode)
        {
            if (currentNode == root)
            {
                root = newNode;
            }
            else if (currentNode == currentNode.Parent.Left)
            {
                AddLeftChild(currentNode.Parent, newNode);
            }
            else
            {
                AddRightChild(currentNode.Parent, newNode);
            }
            return root;
        }

        public static Node BSTDelete(Node root, Node node)
        {
            Node smallestNode;
            if (node.Left == null)
            {
                root = BSTTransplant(root, node, node.Right);
            }
            else if (node.Right == null)
            {
                root = BSTTransplant(root, node, node.Left);
            }
            else
            {
                smallestNode = BSTMinimum(node.Right);
                if (smallestNode.Parent != node)
                {
                    root = BSTTransplant(root, smallestNode, smallestNode.Right);
                    AddRightChild(smallestNode, node.Right);
                }
                root = BSTTransplant(root, node, smallestNode);
                AddLeftChild(smallestNode, node.Left);
            }
            return root;
        }

        public static void PreOrder(Node node)
        {
            if (node != null)
            {
                Console.Write(node.Data + " ");
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }

        public static void PostOrder(Node node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                Console.Write(node.Data + " ");
            }
        }

        public static void InOrder(Node node)
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
