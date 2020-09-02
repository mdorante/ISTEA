using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPositiveInt = false;
            int num = 0;

            while (!isPositiveInt || num <= 0)
            {
                Console.WriteLine("Ingrese un numero entero positivo:");
                isPositiveInt = int.TryParse(Console.ReadLine(), out num);
            }

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Mensaje numero {i}");
            }
        }
    }
}
