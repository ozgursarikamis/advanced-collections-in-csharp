using System;
using System.Collections.Generic;

namespace Collections.LinkedLists
{
    internal class Program
    {
        private static void Main()
        {
            string[] students = { "Jenifer", "Angelina", "Vera" };
            LinkedList<string> list = new LinkedList<string>(students);
            IterateLists(list);

            list.AddFirst("Natalie");
            IterateLists(list);

            var jeniferNode = list.Find("Jenifer") ?? throw new InvalidOperationException();
            list.AddAfter(jeniferNode, "(After Jenifer)");
            IterateLists(list);

            Console.ReadLine();
        }

        private static void IterateLists(LinkedList<string> linkedList)
        {
            Console.WriteLine();

            foreach (var item in linkedList)
            {
                Console.WriteLine($"\t {item}");
            }

            Console.WriteLine();
        }
    }
}
