using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNum = false;
            int num = 0;

            while (isNum == false)
            {
                Console.WriteLine("Ingrese un numero");
                isNum = int.TryParse(Console.ReadLine(), out num);
            }

            if (num % 2 == 0)
            {
                Console.WriteLine("El numero es par.");
            }
            else
            {
                Console.WriteLine("El numero es impar.");
                if (num % 9 == 0)
                {
                    Console.WriteLine("Ademas de impar, es multiplo de 9");
                }
            }
        }
    }
}
