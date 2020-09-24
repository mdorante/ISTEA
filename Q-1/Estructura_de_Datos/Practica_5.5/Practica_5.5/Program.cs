using System;

namespace Practica_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Testeamos funciones 1 y 2
            //int[] testArr = { 1, 4, 3, 4, 5, 6, 4, 2, 4, 5, 6 };
            //int[] testArr2 = new int[3];

            //Console.WriteLine(Ejercicios_1_4.FindNumIndices(testArr, testArr2, 4));

            //Testeamos funcion 3
            int[,] array2D1 = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            int[,] array2D2 = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            int[,] sumArray = Ejercicios_1_4.SumaBidimensional(array2D1, array2D2);

            for (int i = 0; i < sumArray.GetLength(0); i++)
            {
                for (int j = 0; j < sumArray.GetLength(1); j++)
                {
                    Console.Write($"{sumArray[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
