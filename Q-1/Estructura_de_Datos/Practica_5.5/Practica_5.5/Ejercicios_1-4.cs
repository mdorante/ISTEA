namespace Practica_5._5
{
    public class Ejercicios_1_4
    {
        public static int FindNum(int[] numbers, int num)
        {
            int rv = -1;
            int numbersLen = numbers.Length;

            for (int i = 0; i < numbersLen; i++)
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
            int indicesLen = indices.Length;
            int numbersLen = numbers.Length;

            for (int i = 0; i < indicesLen; i++)
            {
                indices[i] = -1;
            }

            for (int i = 0; i < numbersLen; i++)
            {
                if (numbers[i] == num)
                {
                    if (indicesIndex < indicesLen)
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

            for (int i = 0; i < indicesLen; i++)
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
            int filas = arr1.GetLength(0);
            int columnas = arr1.GetLength(1);

            int[,] returnArray = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
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

            int arr1Len = arr1.Length;
            int arr2Len = arr2.Length;

            if (arr1Len == arr2Len)
            {
                for (int i = 0; i < arr1Len; i++)
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

            if (numIguales == arr1Len)
            {
                iguales = true;
            }

            return iguales;
        }
    }
}
