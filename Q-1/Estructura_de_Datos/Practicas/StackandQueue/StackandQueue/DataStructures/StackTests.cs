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

            LinkedListNode<int> pushedNode = test.Push(16);

            Console.WriteLine($"Length after push: {test.Count()}");

            Console.WriteLine($"Pushed value: {pushedNode.Value}");
        }

        public static void TestPop()
        {
            Stack test = new Stack();

            test.Push(13);
            test.Push(23);
            test.Push(367);
            test.Push(48);
            test.Push(59);
            test.Push(854);

            Console.WriteLine($"Length: {test.Count()}");

            LinkedListNode<int> poppedNode = test.Pop();

            Console.WriteLine($"Popped value: {poppedNode.Value}");

            Console.WriteLine($"Length after pop: {test.Count()}");
        }

        public static void TestPeek()
        {
            Stack test = new Stack();

            test.Push(13);
            test.Push(23);
            test.Push(367);
            test.Push(48);
            test.Push(59);
            test.Push(854);

            LinkedListNode<int> lastNode = test.Peek();

            Console.WriteLine($"Length: {test.Count()}");

            Console.WriteLine($"Last value: {lastNode.Value}");

            Console.WriteLine($"Length after peek: {test.Count()}");
        }
    }
}
