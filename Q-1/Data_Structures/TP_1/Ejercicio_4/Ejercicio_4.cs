using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de ºC a ºF:");

            Console.WriteLine("Ingrese la temperatura en ºC:");
            float celsius = float.Parse(Console.ReadLine());

            float fahrenheit = celsius * (9f / 5) + 32;

            Console.WriteLine($"{celsius}ºC equivalen a {fahrenheit}ºF");

            //Esperamos que se presione enter para finalizar.
            Console.WriteLine("Fin del programa");
            Console.ReadLine();
        }
    }
}
