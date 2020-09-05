using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantNumeros = 0;
            bool isNum = false, isNumNumeros = false;
            int[] numeros;
            int buffer;

            while (!isNum || cantNumeros == 0)
            {
                Console.WriteLine("Indique la cantidad de numeros que desea ingrear:");
                isNum = int.TryParse(Console.ReadLine(), out cantNumeros);
            }

            numeros = new int[cantNumeros];

            // Llenamos el array numeros
            for (int i = 0; i < numeros.Length; i++)
            {
                while (!isNumNumeros)
                {
                    Console.WriteLine($"Ingrese el numero {i + 1}:");
                    isNumNumeros = int.TryParse(Console.ReadLine(), out numeros[i]);
                }
                isNumNumeros = false;
            }

            // Mostramos los numeros ingresados en el orden ingresada
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"[{numeros[i]}] ");

                if (i == numeros.Length - 1)
                {
                    Console.Write(Environment.NewLine);
                }
            }

            buffer = numeros[0];
            numeros[0] = numeros[cantNumeros - 1];
            numeros[cantNumeros - 1] = buffer;

            // Mostramos los numeros ingresados intercambiando el primero por el ultimo
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"[{numeros[i]}] ");

                if (i == numeros.Length - 1)
                {
                    Console.Write(Environment.NewLine);
                }
            }
        }
    }
}
