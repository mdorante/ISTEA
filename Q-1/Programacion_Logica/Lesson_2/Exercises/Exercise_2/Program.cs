using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero b:");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"a: {a} es mayor que b: {b}");
            }
            else if (a < b)
            {
                Console.WriteLine($"b: {b} es mayor que a: {a}");
            }
            else
            {
                Console.WriteLine($"a: {a} y b: {b} son iguales.");
            }
        }
    }
}
