using System;
using System.Collections.Generic;

namespace StackandQueue.DataStructures
{
    public class StackTests
    {
        public static void TestCount()
        {
            Stack test = new Stack();

            Console.WriteLine($"Length of an empty stack: {test.Count()}");
        }

        public static void TestPush()
        {
            Stack test = new Stack();

            Console.WriteLine($"Length before push: {test.Count()}");

            LinkedListNode<string> pushedNode = test.Push("hi");

            Console.WriteLine($"Length after push: {test.Count()}");

            Console.WriteLine($"Pushed value: {pushedNode.Value}");
        }

        public static void TestPop()
        {
            Stack test = new Stack();

            test.Push("hola");
            test.Push("ciao");
            test.Push("bonjour");
            test.Push("konichiwa");
            test.Push("namaste");

            Console.WriteLine($"Length: {test.Count()}");

            LinkedListNode<string> poppedNode = test.Pop();

            Console.WriteLine($"Popped value: {poppedNode.Value}");

            Console.WriteLine($"Length after pop: {test.Count()}");
        }

        public static void TestPeek()
        {
            Stack test = new Stack();

            test.Push("hola");
            test.Push("ciao");
            test.Push("bonjour");
            test.Push("konichiwa");
            test.Push("namaste");

            LinkedListNode<string> lastNode = test.Peek();

            Console.WriteLine($"Length: {test.Count()}");

            Console.WriteLine($"Last value: {lastNode.Value}");

            Console.WriteLine($"Length after peek: {test.Count()}");
        }
    }
}
