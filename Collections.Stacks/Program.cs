using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections.Stacks
{
    internal class Program
    {
        private static void Main()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            int[] arr = new int[] {1, 2, 3, 4};
            var stackFromArray = new Stack<int>(arr);

            foreach (var item in stackFromArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
