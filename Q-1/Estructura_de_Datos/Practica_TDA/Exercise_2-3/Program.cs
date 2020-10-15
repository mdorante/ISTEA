using System;

namespace Exercise_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circle = new Circulo(5f, ConsoleColor.Cyan);
            float area = circle.ObtenerArea();
            Console.WriteLine($"El area del circulo es {area}");
            circle.Dibujar();
        }
    }
}
