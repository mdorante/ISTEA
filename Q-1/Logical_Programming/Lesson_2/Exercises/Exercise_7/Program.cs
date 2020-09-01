using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 0;
            int monthNumber = 0;
            string month = "";
            int year = 0;
            bool isNum = false;

            while (isNum == false || day > 31 || day <= 0)
            {
                Console.WriteLine("Ingrese el numero de dia (1 - 31):");
                isNum = int.TryParse(Console.ReadLine(), out day);
            }

            while (isNum == false || monthNumber > 12 || monthNumber <= 0)
            {
                Console.WriteLine("Ingrese el numero de mes (1 - 12):");
                isNum = int.TryParse(Console.ReadLine(), out monthNumber);

                switch (monthNumber)
                {
                    case 1:
                        month = "Enero";
                        break;
                    case 2:
                        month = "Febrero";
                        break;
                    case 3:
                        month = "Marzo";
                        break;
                    case 4:
                        month = "Abril";
                        break;
                    case 5:
                        month = "Mayo";
                        break;
                    case 6:
                        month = "Junio";
                        break;
                    case 7:
                        month = "Julio";
                        break;
                    case 8:
                        month = "Agosto";
                        break;
                    case 9:
                        month = "Septiembre";
                        break;
                    case 10:
                        month = "Octubre";
                        break;
                    case 11:
                        month = "Noviembre";
                        break;
                    case 12:
                        month = "Diciembre";
                        break;
                }
            }

            while (isNum == false || year == 0)
            {
                Console.WriteLine("Ingrese el numero de año:");
                isNum = int.TryParse(Console.ReadLine(), out year);
            }

            Console.WriteLine($"Usted ha ingresado la fecha {day} de {month} del {year}");
        }
    }
}