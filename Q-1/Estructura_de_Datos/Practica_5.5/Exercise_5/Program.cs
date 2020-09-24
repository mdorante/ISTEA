﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            static int GetNumNames()
            {
                int cantNombres = 0;
                bool isNumberNames = false;

                while (!isNumberNames || cantNombres == 0)
                {
                    Console.Write("Indique la cantidad de nombres a ingresar: ");
                    isNumberNames = int.TryParse(Console.ReadLine(), out cantNombres);
                }

                return cantNombres;
            }

            static string[] GetNames(string[] namesArr)
            {
                for (int i = 0; i < namesArr.Length; i++)
                {
                    Console.Write($"Indique el nombre numero {i + 1}: ");
                    namesArr[i] = Console.ReadLine();
                }

                return namesArr;
            }

            static int[] GetAges(int[] agesArr)
            {
                bool isNumberAges = false;

                for (int i = 0; i < agesArr.Length; i++)
                {
                    while (!isNumberAges)
                    {
                        Console.Write($"Indique una edad para el nombre numero {i + 1}: ");
                        isNumberAges = int.TryParse(Console.ReadLine(), out agesArr[i]);
                    }
                    isNumberAges = false; // reseteamos el valor de isNumberAges para que en el siguiente nombre vuelva a pedir edad
                }

                return agesArr;
            }

            static float[] GetWeights(float[] weightsArr)
            {
                bool isNumberPesos = false;

                for (int i = 0; i < weightsArr.Length; i++)
                {
                    while (!isNumberPesos)
                    {
                        Console.Write($"Indique el peso en kilos para el nombre numero {i + 1}: ");
                        isNumberPesos = float.TryParse(Console.ReadLine(), out weightsArr[i]);
                    }
                    isNumberPesos = false;
                }

                return weightsArr;
            }

            static float[] GetStatures(float[] staturesArr)
            {
                bool isNumberAlturas = false;

                for (int i = 0; i < staturesArr.Length; i++)
                {
                    while (!isNumberAlturas)
                    {
                        Console.Write($"Indique la altura en metros para el nombre numero {i + 1}: ");
                        isNumberAlturas = float.TryParse(Console.ReadLine(), out staturesArr[i]);
                    }
                    isNumberAlturas = false;
                }

                return staturesArr;
            }

            static float[] GetImc(float[] imcArr, float[] staturesArr, float[] weightsArr)
            {
                for (int i = 0; i < imcArr.Length; i++)
                {
                    imcArr[i] = weightsArr[i] / (float)Math.Pow(staturesArr[i], 2);
                }

                return imcArr;
            }

            static string GetImcMessage(string[] namesArr, float[] imcArr)
            {
                string imcMessage = "";

                for (int x = namesArr.Length - 1; x >= 0; x--)
                {
                    if (imcArr[x] <= 15f)
                    {
                        imcMessage = "Delgadez muy severa";
                    }
                    else if (imcArr[x] <= 15.9f)
                    {
                        imcMessage = "Delgadez severa";
                    }
                    else if (imcArr[x] <= 18.4f)
                    {
                        imcMessage = "Delgadez";
                    }
                    else if (imcArr[x] <= 24.9f)
                    {
                        imcMessage = "Saludable";
                    }
                    else if (imcArr[x] <= 29.9f)
                    {
                        imcMessage = "Sobrepeso";
                    }
                    else if (imcArr[x] <= 34.9f)
                    {
                        imcMessage = "Obesidad moderada";
                    }
                    else if (imcArr[x] <= 39.9f)
                    {
                        imcMessage = "Obesidad Severa";
                    }
                    else if (imcArr[x] >= 40f)
                    {
                        imcMessage = "Obesidad Mórbida";
                    }
                }

                return imcMessage;
            }

            static void PrintPersonIMCDetails(string[] namesArr, int[] agesArr, float[] imcArr, string imcMessage)
            {
                for (int x = namesArr.Length - 1; x >= 0; x--)
                {
                    Console.WriteLine($"Elemento [{x + 1}] Nombre:{namesArr[x]} Edad:{agesArr[x]} IMC:{imcArr[x]} Categoria:{imcMessage}");
                }
            }

            int numNames = GetNumNames();

            string[] nombres = new string[numNames];
            nombres = GetNames(nombres);

            int[] edades = new int[numNames];
            edades = GetAges(edades);

            float[] pesos = new float[numNames];
            pesos = GetWeights(pesos);

            float[] alturas = new float[numNames];
            alturas = GetStatures(alturas);

            float[] imc = new float[numNames];
            imc = GetImc(imc, alturas, pesos);

            string imcMessage = GetImcMessage(nombres, imc);

            PrintPersonIMCDetails(nombres, edades, imc, imcMessage);
        }
    }
}
