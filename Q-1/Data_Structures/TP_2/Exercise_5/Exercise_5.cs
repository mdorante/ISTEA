using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese un numero mayor o igual a 9 y menor o igual a 40:");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 9 || numero > 40)
            {
                Console.WriteLine("El numero debe ser mayor o igual a 9 y menor o igual a 40!");
                Environment.Exit(-1);
            }

            int divisor = 0;

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    divisor = i;
                }
            }
            
            Console.WriteLine($"Divisor: {divisor}");

            int[,] resultado = new int[numero / divisor, divisor];
            for (int i = 0; i < resultado.GetLength(0); i++)
            {
                for (int j = 0; j < resultado.GetLength(1); j++)
                {
                    Console.Write($"[{resultado[i, j]}] ");
                }
                Console.WriteLine();
            }
        }
    }
}
