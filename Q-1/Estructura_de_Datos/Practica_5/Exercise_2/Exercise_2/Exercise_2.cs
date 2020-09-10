using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1 = 129.876;
            double numero2 = 32.87;

            double suma = Sumar(numero1, numero2);

            Console.WriteLine($"La suma de {numero1} y {numero2} es: {suma}");
        }

        static double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
