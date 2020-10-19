using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingrese su nombre:");
            string name = Console.ReadLine();

            Saludar(name);
        }

        static void Saludar(string nombre)
        {
            Console.WriteLine($"Hola {nombre}");
        }
    }
}
