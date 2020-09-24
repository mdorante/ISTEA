using System;

namespace Practica_5._5
{
    public class Ejercicios_1_4
    {
        public static int FindNum(int[] numbers, int num)
        {
            int rv = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    rv = i;
                    break;
                }
            }

            return rv;
        }

        public static int FindNumIndices(int[] numbers, int[] indices, int num)
        {
            int rv = 0;
            int indicesIndex = 0;

            for (int i = 0; i < indices.Length; i++)
            {
                indices[i] = -1;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    if (indicesIndex < indices.Length)
                    {
                        indices[indicesIndex] = i;
                        indicesIndex++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < indices.Length; i++)
            {
                if (indices[i] != -1)
                {
                    rv++;
                }
            }

            return rv;
        }

        public static int[,] SumaBidimensional(int[,] arr1, int[,] arr2)
        {
            int[,] returnArray = new int[arr1.GetLength(0), arr1.GetLength(1)];

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    returnArray[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            return returnArray;
        }

        public static bool ArraysIguales(int[] arr1, int[] arr2)
        {
            bool iguales = false;
            int numIguales = 0;

            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        numIguales++;
                    }
                    else
                    {
                        // Si se consigue un solo elemento diferente, ya no son iguales los arrays
                        break;
                    }
                }
            }

            if (numIguales == arr1.Length)
            {
                iguales = true;
            }

            return iguales;
        }
    }
}
