using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string intro = "Este programa recibe dos numeros cualesquiera y devuelve su suma.\n";
            Console.WriteLine(intro);

            Console.WriteLine("Ingrese el primer numero:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"La suma de {num1} y {num2} es: {num1 + num2}");

        }
    }
}
