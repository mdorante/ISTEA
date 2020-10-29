using System;
using System.Collections.Generic;
using StackandQueue.DataStructures;

namespace StackandQueue
{
    class Program
    {
        static void StackOfBooks()
        {
            Stack books = new Stack();

            // add first book
            books.Push("Moby Dick");

            // add second book
            books.Push("The Great Gatsby");

            // add third book
            books.Push("Frankenstein");

            // add fourth book
            books.Push("Dracula");

            int amountOfBooks = books.Count();

            Console.WriteLine($"You have {amountOfBooks} books stacked up.");

            Console.WriteLine("\nThis is the order in which you have to read the books:");

            for (int i = 0; i < amountOfBooks; i++)
            {
                Console.WriteLine(books.Pop().Value);
            }

            Console.WriteLine($"\nBooks left after reading all of them: {books.Count()}");

        }


        static void RestaurantOrders()
        {
            Queue tables = new Queue();

            // add five orders from five different tables
            tables.Enqueue(6);
            tables.Enqueue(33);
            tables.Enqueue(17);
            tables.Enqueue(21);
            tables.Enqueue(9);

            int amountOfOrders = tables.Count();

            Console.WriteLine($"The restaurant has {tables.Count()} tables waiting for food.");

            Console.WriteLine("\nStart dispatching orders by table:");

            for (int i = 0; i < amountOfOrders; i++)
            {
                Console.WriteLine($"Dispatch order for table #{tables.Dequeue().Value}");
            }

            Console.WriteLine($"Pending orders: {tables.Count()}");
        }

        static void Main(string[] args)
        {
            //StackTests.TestCount();
            //StackTests.TestPush();
            //StackTests.TestPop();
            //StackTests.TestPeek();

            //QueueTests.TestCount();
            //QueueTests.TestEnqueue();
            //QueueTests.TestDequeue();
            //QueueTests.TestPeek();

            //StackOfBooks();
            //RestaurantOrders();

        }
    }
}
