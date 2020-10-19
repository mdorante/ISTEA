using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantNombres = 0;
            string[] nombres;
            int[] edades;
            float[] pesos, alturas, imc;
            bool isNumberNames = false, isNumberAges = false, isNumberPesos = false, isNumberAlturas = false;
            string imcMessage = "";

            while (!isNumberNames || cantNombres == 0)
            {
                Console.Write("Indique la cantidad de nombres a ingresar: ");
                isNumberNames = int.TryParse(Console.ReadLine(), out cantNombres);
            }

            nombres = new string[cantNombres];
            edades = new int[cantNombres];
            pesos = new float[cantNombres];
            alturas = new float[cantNombres];
            imc = new float[cantNombres];

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

                while (!isNumberPesos)
                {
                    Console.Write($"Indique el peso en kilos para el nombre numero {i + 1}: ");
                    isNumberPesos = float.TryParse(Console.ReadLine(), out pesos[i]);
                }
                isNumberPesos = false;

                while (!isNumberAlturas)
                {
                    Console.Write($"Indique la altura en metros para el nombre numero {i + 1}: ");
                    isNumberAlturas = float.TryParse(Console.ReadLine(), out alturas[i]);
                }
                isNumberAlturas = false;

                imc[i] = pesos[i] / (float)Math.Pow(alturas[i], 2);
            }

            Console.WriteLine("Usted escribio: ");

            for (int x = nombres.Length - 1; x >= 0; x--)
            {
                if (imc[x] <= 15f)
                {
                    imcMessage = "Delgadez muy severa";
                }
                else if (imc[x] <= 15.9f)
                {
                    imcMessage = "Delgadez severa";
                }
                else if (imc[x] <= 18.4f)
                {
                    imcMessage = "Delgadez";
                }
                else if (imc[x] <= 24.9f)
                {
                    imcMessage = "Saludable";
                }
                else if (imc[x] <= 29.9f)
                {
                    imcMessage = "Sobrepeso";
                }
                else if (imc[x] <= 34.9f)
                {
                    imcMessage = "Obesidad moderada";
                }
                else if (imc[x] <= 39.9f)
                {
                    imcMessage = "Obesidad Severa";
                }
                else if (imc[x] >= 40f)
                {
                    imcMessage = "Obesidad Mórbida";
                }

                Console.WriteLine($"Elemento [{x + 1}] Nombre:{nombres[x]} Edad:{edades[x]} IMC:{imc[x]} Categoria:{imcMessage}");
            }

            Console.ReadLine();
        }
    }
}
