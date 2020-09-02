using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Ingrese un valor para a:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un valor para b:");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Los numeros a y b no deben ser iguales!");
                Environment.Exit(-1);
            }

            if (a > b)
            {
                Console.WriteLine("El numero a debe ser menor que el numero b!");
                Environment.Exit(-1);
            }

            Console.WriteLine();
            Console.WriteLine($"Los numero pares dentro del rango {a} - {b} (incluyendo las cotas) son:");

            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}