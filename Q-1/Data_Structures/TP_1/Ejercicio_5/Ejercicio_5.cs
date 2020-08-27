using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            char new_line = '\n';

            Console.WriteLine("Este programa determina si x es par o no." + new_line);

            Console.WriteLine("Ingrese un numero para x:");
            x = int.Parse(Console.ReadLine());

            if (x % 2 != 0)
            {
                Console.WriteLine("x es impar." + new_line);
            }
            else
            {
                Console.WriteLine("x es par." + new_line);
            }

            //Esperamos que se presione enter para finalizar.
            Console.WriteLine("Fin del programa");
            Console.ReadLine();
        }
    }
}
