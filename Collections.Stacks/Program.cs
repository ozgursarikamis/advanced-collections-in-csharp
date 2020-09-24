using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections.Stacks
{
    internal class Program
    {
        private static void Main()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
