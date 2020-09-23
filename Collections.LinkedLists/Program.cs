using System;
using System.Collections.Generic;

namespace Collections.LinkedLists
{
    internal class Program
    {
        private static void Main()
        {
            LinkedListNode<string> node = new LinkedListNode<string>("orange");
            DisplayProperties(node);

            LinkedList<string> ll = new LinkedList<string>();
            ll.AddLast(node);
            Console.WriteLine("After adding node to the empty LinkedList");
            DisplayProperties(node);

            ll.AddFirst("red");
            ll.AddLast("yellow");

            Console.WriteLine("After adding red and yellow");
            DisplayProperties(node);

            Console.ReadLine();
        }

        private static void DisplayProperties(LinkedListNode<string> node)
        {
            Console.WriteLine();
            Console.WriteLine(node.List == null
                ? "Node is not linked"
                : $"Node belongs to a linked list with {node.List.Count} item(s)");

            Console.WriteLine(node.Previous == null
                ? "this is the first node"
                : $"Value of previous node is {node.Previous.Value}");

            Console.WriteLine($"Value of the current node: {node.Value}");

            Console.WriteLine(node.Next == null 
                ? "This is the last node"
                : $"Value of next node: {node.Next.Value}");

            Console.WriteLine();
        }
    }
}
