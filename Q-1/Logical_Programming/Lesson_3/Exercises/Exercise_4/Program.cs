using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isPositiveInt = false;
            int num = 0, a = 0, b = 1, c = 0;

            while (!isPositiveInt || num < 0)
            {
                Console.WriteLine("Ingrese un numero para calcular la serie de Fibonacci:");
                isPositiveInt = int.TryParse(Console.ReadLine(), out num);
            }

            Console.Write($"{a} {b} ");
            for (int i = 2; i < num; i++)
            {
                c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;

                if (i == num - 1)
                {
                    Console.Write(Environment.NewLine);
                }
            }
        }
    }
}
