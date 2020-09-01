using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPositiveInt1 = false, isPositiveInt2 = false;
            int num1 = 0, num2 = 0;

            while (!isPositiveInt1 || num1 <= 0)
            {
                Console.WriteLine("Ingrese un numero entero y positivo:");
                isPositiveInt1 = int.TryParse(Console.ReadLine(), out num1);
            }

            while (!isPositiveInt2 || num2 <= 0 || num2 <= num1)
            {
                Console.WriteLine("Ingrese un numero entero, positivo y mayor al numero anterior:");
                isPositiveInt2 = int.TryParse(Console.ReadLine(), out num2);
            }

            Console.WriteLine();
            Console.WriteLine($"Los numeros pares en el rango {num1} - {num2} son:");
            for (int i = num1; i < num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Los numeros impares en el rango {num1} - {num2} son:");
            for (int i = num1; i < num2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Los numeros impares multiplos de 5 en el rango {num1} - {num2} son:");
            for (int i = num1 + 1; i < num2; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
