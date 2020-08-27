using System;

namespace TP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;// definir para probar
            int z;//definir para probar

            Console.WriteLine("Ingrese un valor para x:");
            x = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un valor para z:");
            z = int.Parse(Console.ReadLine());
            
            if (z != 0 && x % z == 0)
            {
                Console.WriteLine("x es divisible por z");
            }

            //Esperamos que se presione enter para finalizar.
            Console.WriteLine("Fin del programa");
            Console.ReadLine();

        }

    }
}