using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            while (num1 >= 0 || num2 <= 0)
            {
                Console.WriteLine("Ingrese un numero negativo:");
                int.TryParse(Console.ReadLine(), out num1);

                Console.WriteLine("Ingrese un numero positivo, mayor a 0:");
                int.TryParse(Console.ReadLine(), out num2);
            }

            Console.WriteLine($"Los numeros dentro del rango {num1} - {num2} son:");

            for (int i = num1 + 1; i < num2; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
