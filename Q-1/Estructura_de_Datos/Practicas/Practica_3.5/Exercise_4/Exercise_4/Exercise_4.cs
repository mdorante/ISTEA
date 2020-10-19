using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int fact = 1;
            bool isNum = false;

            while (!isNum)
            {
                Console.WriteLine("Por favor, ingrese un numero:");
                isNum = int.TryParse(Console.ReadLine(), out number);
            }

            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }

            Console.WriteLine($"El factorial de {number} es: {fact}");
        }
    }
}
