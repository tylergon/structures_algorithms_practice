using System;
using DataStruct.Stack;

namespace Algorithm_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            InteractableStack s = new InteractableStack();
            s.TestOutStack();

            Console.Write("\nPress any key to exit...");
            Console.ReadKey(false);
        }
    }
}
