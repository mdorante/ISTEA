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

            if (EsAnioBisiesto(year))
            {
                diasDeCadaMes[1] = 29;
            }

            switch (month)
            {
                case 1:
                    cantidad = diasDeCadaMes[0];
                    break;
                case 2:
                    cantidad = diasDeCadaMes[1];
                    break;
                case 3:
                    cantidad = diasDeCadaMes[2];
                    break;
                case 4:
                    cantidad = diasDeCadaMes[3];
                    break;
                case 5:
                    cantidad = diasDeCadaMes[4];
                    break;
                case 6:
                    cantidad = diasDeCadaMes[5];
                    break;
                case 7:
                    cantidad = diasDeCadaMes[6];
                    break;
                case 8:
                    cantidad = diasDeCadaMes[7];
                    break;
                case 9:
                    cantidad = diasDeCadaMes[8];
                    break;
                case 10:
                    cantidad = diasDeCadaMes[9];
                    break;
                case 11:
                    cantidad = diasDeCadaMes[10];
                    break;
                case 12:
                    cantidad = diasDeCadaMes[11];
                    break;

                default:
                    Console.WriteLine("No ha ingresado un numero correspondiente a un mes del año");
                    break;
            }
            return cantidad;
        }
    }
}
