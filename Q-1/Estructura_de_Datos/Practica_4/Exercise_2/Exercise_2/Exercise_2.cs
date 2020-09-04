using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantNombres = 0;
            string[] nombres;

            Console.Write("Indique la cantidad de nombres a ingresar: ");
            cantNombres = int.Parse(Console.ReadLine());

            nombres = new string[cantNombres];

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write($"Indique el nombre numero {i + 1}: ");
                nombres[i] = Console.ReadLine();
            }

            Console.WriteLine("Usted escribio: ");


            for (int x = nombres.Length - 1; x >= 0; x--)
            {
                Console.WriteLine(nombres[x]);
            }

            Console.ReadLine();

            /*
             El programa recibe una cantidad de nombres, luego pide que se ingrese por consola un nombre hasta llegar a la cantidad ingresada anteriormente.
            Despues muestra por consola cada uno de los nombres ingresados, en orden del ultimo al primero.
             */
        }
    }
}
