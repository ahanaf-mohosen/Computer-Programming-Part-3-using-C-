using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace doubly_linked_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node head = null;

            // Test appending nodes
            Console.WriteLine("Appending 10, 20, 30 to the list:");
            head = Append(head, 10);
            head = Append(head, 20);
            head = Append(head, 30);
            PrintList(head);

            // Test prepending a node
            Console.WriteLine("Prepending 5 to the list:");
            head = Prepend(head, 5);
            PrintList(head);

            // Test removing the head node
            Console.WriteLine("Removing the head node (5):");
            head = RemoveNode(head, head);
            PrintList(head);

            // Test removing a middle node
            Console.WriteLine("Removing a middle node (20):");
            Node middleNode = head.Next; // 20 is now the second node
            head = RemoveNode(head, middleNode);
            PrintList(head);

            // Test removing the last node
            Console.WriteLine("Removing the last node (30):");
            Node lastNode = head.Next; // 30 is now the last node
            head = RemoveNode(head, lastNode);
            PrintList(head);
        }

        static Node CreateNode(int item, Node prev, Node next)
        {
            Node newNode = new Node();
            newNode.Data = item;
            newNode.Prev = prev;
            newNode.Next = next;
            return newNode;
        }

        static Node Prepend(Node head, int item)
        {
            Node newNode = CreateNode(item, null, head);
            if (head != null)
            {
                head.Prev = newNode;
            }
            return newNode;
        }

        static Node Append(Node head, int item)
        {
            Node newNode = CreateNode(item, null, null);
            if (head == null)
            {
                return newNode;
            }
            Node currentNode = head;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = newNode;
            newNode.Prev = currentNode;
            return head;
        }

        static Node RemoveNode(Node head, Node node)
        {
            if (node == null || head == null)
            {
                return head;
            }

            if (head == node)
            {
                head = head.Next;
                if (head != null)
                {
                    head.Prev = null;
                }
                return head;
            }

            Node prevNode = node.Prev;
            Node nextNode = node.Next;

            if (prevNode != null)
            {
                prevNode.Next = nextNode;
            }
            if (nextNode != null)
            {
                nextNode.Prev = prevNode;
            }
            return head;
        }

        static void PrintList(Node head)
        {
            Node current = head;
            Console.Write("List: ");
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
