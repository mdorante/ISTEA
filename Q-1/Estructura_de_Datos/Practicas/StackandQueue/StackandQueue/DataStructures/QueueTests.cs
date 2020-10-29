using System;
using System.Collections.Generic;

namespace StackandQueue.DataStructures
{
    public class QueueTests
    {
        public static void TestCount()
        {
            Queue test = new Queue();

            Console.WriteLine($"Length of an empty queue: {test.Count()}");
        }

        public static void TestEnqueue()
        {
            Queue test = new Queue();

            Console.WriteLine($"Length before enqueue: {test.Count()}");

            LinkedListNode<int> enqueuedNode = test.Enqueue(16);

            Console.WriteLine($"Length after enqueue: {test.Count()}");

            Console.WriteLine($"Enqueued value: {enqueuedNode.Value}");
        }

        public static void TestDequeue()
        {
            Queue test = new Queue();

            test.Enqueue(13);
            test.Enqueue(23);
            test.Enqueue(367);
            test.Enqueue(48);
            test.Enqueue(59);
            test.Enqueue(854);

            Console.WriteLine($"Length: {test.Count()}");

            LinkedListNode<int> dequeuedNode = test.Dequeue();

            Console.WriteLine($"Dequeued value: {dequeuedNode.Value}");

            Console.WriteLine($"Length after dequeue: {test.Count()}");
        }

        public static void TestPeek()
        {
            Queue test = new Queue();

            test.Enqueue(13);
            test.Enqueue(23);
            test.Enqueue(367);
            test.Enqueue(48);
            test.Enqueue(59);
            test.Enqueue(854);

            LinkedListNode<int> firstNode = test.Peek();

            Console.WriteLine($"Length: {test.Count()}");

            Console.WriteLine($"First value: {firstNode.Value}");

            Console.WriteLine($"Length after peek: {test.Count()}");
        }
    }
}
