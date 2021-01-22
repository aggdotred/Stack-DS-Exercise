using System;

namespace Stack_DS_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Clear();
            Console.WriteLine(stack.Pop());
        }
    }
}
