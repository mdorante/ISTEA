using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad:");
            int edad;
            bool isNumber = int.TryParse(Console.ReadLine(), out edad);

            if (isNumber == false)
            {
                Console.WriteLine("Por favor ingrese un numero");
            }
            else
            {
                Console.WriteLine($"Hola {nombre}, tu edad es {edad}. ¿Como estas?");
            }

        }
    }
}
