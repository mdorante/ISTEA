using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = 2;
            int year1 = 2020;
            int year2 = 2021;

            int dias1 = DiasEnElMes(month, year1);
            int dias2 = DiasEnElMes(month, year2);

            Console.WriteLine($"En el año {year1}, el mes {month} tiene {dias1} dias.");
            Console.WriteLine($"En el año {year2}, el mes {month} tiene {dias2} dias.");
        }

        static bool EsAnioBisiesto(int anio)
        {
            return (anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0));
        }

        static int DiasEnElMes(int month, int year)
        {
            int[] diasDeCadaMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int cantidad = 0;

            cantidad = diasDeCadaMes[month - 1];

            if (EsAnioBisiesto(year) && month == 2)
            {
                cantidad = diasDeCadaMes[month - 1] + 1;
            }

            return cantidad;
        }
    }
}
