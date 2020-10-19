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
            Console.WriteLine($"Orden original:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"[{numeros[i]}] ");

                if (i == numeros.Length - 1)
                {
                    Console.Write(Environment.NewLine);
                }
            }

            // Movemos el numero de la primera posicion hasta la ultima
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                buffer = numeros[i];
                numeros[i] = numeros[i + 1];
                numeros[i + 1] = buffer;
            }

            // Mostramos los numeros ingresados intercambiando el primero por el ultimo
            Console.WriteLine($"Despues del movimiento:");
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
