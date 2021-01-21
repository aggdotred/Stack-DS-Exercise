using System;

namespace Stack_DS_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push("Hi");
            Console.WriteLine(stack.Pop());
            stack.Push("HiHi");
            stack.Push("Hello");
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            stack.Clear();
        }
    }
}
