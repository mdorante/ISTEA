using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero c:");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine($"a: {a} es mayor que b: {b} y c: {c}");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"b: {b} es mayor que a: {a} y c: {c}");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine($"c: {a} es mayor que a: {a} y b: {b}");
            }
        }
    }
}
