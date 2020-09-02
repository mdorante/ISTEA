using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            bool isNum = false;

            while (!isNum)
            {
                Console.WriteLine("Por favor ingrese un numero mayor o igual a 9 y menor o igual a 40:");
                isNum = int.TryParse(Console.ReadLine(), out numero);
            }

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

            int[] cuentaNumeros = new int[numero];

            for (int i = 0; i < cuentaNumeros.Length; i++)
            {
                cuentaNumeros[i] = i + 1;
            }

            Console.WriteLine($"Divisor: {divisor}");

            Array.Reverse(cuentaNumeros);

            for (int i = 0; i < cuentaNumeros.Length; i++)
            {
                if (i % divisor == 0)
                {
                    Console.WriteLine();
                }

                Console.Write($"[{cuentaNumeros[i]}] ");

                if (i == cuentaNumeros.Length - 1)
                {
                    Console.Write(Environment.NewLine); // para que no muestre el '%' en sistemas UNIX
                }
            }
        }
    }
}
