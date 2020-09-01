using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 10;

            Console.WriteLine($"{a}, {b}");
            a = a + b; // 7 + 10 = 17
            b = a - b; // 17 - 10 = 7
            a = a - b; // 17 - 7 = 10
            Console.WriteLine($"{a}, {b}");
        }
    }
}
