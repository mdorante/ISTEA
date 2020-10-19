using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2021;
            bool esBisiesto = EsAnioBisiesto(year);

            if (esBisiesto)
            {
                Console.WriteLine($"El año {year} es bisiesto.");
            }
            else
            {
                Console.WriteLine($"El año {year} no es bisiesto.");
            }
        }

        static bool EsAnioBisiesto(int anio)
        {
            return (anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0));
        }
    }
}
