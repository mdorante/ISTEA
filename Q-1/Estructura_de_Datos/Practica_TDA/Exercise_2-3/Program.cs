using System;

namespace Exercise_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Circulo circle = new Circulo(5f, ConsoleColor.Cyan);
            // float area = circle.ObtenerArea();
            // Console.WriteLine($"El area del circulo es {area}");
            // circle.Dibujar();

            Rectangulo rectangle = new Rectangulo(7f, 15f, ConsoleColor.Green);
            float area = rectangle.ObtenerArea();
            float perimetro = rectangle.ObtenerPerimetro();
            Console.WriteLine($"El area del rectangulo es: {area}");
            Console.WriteLine($"El perimetro del rectangulo es: {perimetro}");
            rectangle.Dibujar();
        }
    }
}
