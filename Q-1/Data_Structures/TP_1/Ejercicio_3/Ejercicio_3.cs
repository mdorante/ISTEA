using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa muestra la cantidad de dias que contiene el mes especificado (del 2020).\n");
            Console.WriteLine("Ingrese el numero de un mes (del 1 al 12):");

            int mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Enero tiene 31 dias.");
                    break;
                case 2:
                    Console.WriteLine("Febrero tiene 29 dias.");
                    break;
                case 3:
                    Console.WriteLine("Marzo tiene 31 dias.");
                    break;
                case 4:
                    Console.WriteLine("Abril tiene 30 dias.");
                    break;
                case 5:
                    Console.WriteLine("Mayo tiene 31 dias.");
                    break;
                case 6:
                    Console.WriteLine("Junio tiene 30 dias.");
                    break;
                case 7:
                    Console.WriteLine("Julio tiene 31 dias.");
                    break;
                case 8:
                    Console.WriteLine("Agosto tiene 31 dias.");
                    break;
                case 9:
                    Console.WriteLine("Septiembre tiene 30 dias.");
                    break;
                case 10:
                    Console.WriteLine("Octubre tiene 31 dias.");
                    break;
                case 11:
                    Console.WriteLine("Noviembre tiene 30 dias.");
                    break;
                case 12:
                    Console.WriteLine("Diciembre tiene 31 dias.");
                    break;
                default:
                    Console.WriteLine("El numero no es valido para un mes calendario.");
                    break;
            }

            //Esperamos que se presione enter para finalizar.
            Console.WriteLine("Fin del programa");
            Console.ReadLine();
        }
    }
}
