using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantNombres = 0;
            bool isNumberNames = false, isNumberAges = false;
            string[] nombres;
            int[] edades;

            while (!isNumberNames || cantNombres == 0)
            {
                Console.Write("Indique la cantidad de nombres a ingresar: ");
                isNumberNames = int.TryParse(Console.ReadLine(), out cantNombres);
            }

            nombres = new string[cantNombres];
            edades = new int[cantNombres];

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write($"Indique el nombre numero {i + 1}: ");
                nombres[i] = Console.ReadLine();

                while (!isNumberAges)
                {
                    Console.Write($"Indique una edad para el nombre numero {i + 1}: ");
                    isNumberAges = int.TryParse(Console.ReadLine(), out edades[i]);
                }
                isNumberAges = false; // reseteamos el valor de isNumberAges para que en el siguiente nombre vuelva a pedir edad
            }

            Console.WriteLine("Usted escribio: ");


            for (int x = nombres.Length - 1; x >= 0; x--)
            {
                Console.WriteLine($"Elemento [{x + 1}] Nombre:{nombres[x]} Edad:{edades[x]}");
            }

            Console.ReadLine();
        }
    }
}
