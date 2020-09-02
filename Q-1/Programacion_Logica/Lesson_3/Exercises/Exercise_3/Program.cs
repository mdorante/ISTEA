using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPositiveInt = false;
            int num = 0;

            while (!isPositiveInt || num < 0)
            {
                Console.WriteLine("Ingrese un numero entero positivo:");
                isPositiveInt = int.TryParse(Console.ReadLine(), out num);
            }

            int fact = 1;
            if (num == 0)
            {
                Console.WriteLine($"Factorial de {num}: {fact}");
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    fact *= i;
                }
                Console.WriteLine($"Factorial de {num}: {fact}");
            }

        }
    }
}
