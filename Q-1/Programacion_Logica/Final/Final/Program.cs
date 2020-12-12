using System;
using System.Collections.Generic;
using System.Linq;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1
            static bool IsPrime(int num)
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                        return false;
                }

                return num > 1;
            }

            static int SumPrimes(int num)
            {
                int suma = 0;

                for (int i = 0; i < num; i++)
                {
                    if (IsPrime(i))
                    {
                        suma += i;
                    }
                }
                return suma;
            }

            // Ejercicio 2
            static List<int> GetMultiplesOfThree(int from, int to)
            {
                List<int> multiples = new List<int>();

                for (int i = from; i < to; i++)
                {
                    if (i % 3 == 0)
                    {
                        multiples.Add(i);
                    }
                }
                return multiples;
            }

            // Ejercicio 3
            static int GetMin(List<int> nums)
            {
                if (nums == null)
                {
                    throw new ArgumentNullException("nums cannot be null");
                }

                int min = nums[0];

                for (int i = 1; i < nums.Count; i++)
                {
                    if (nums[i] < min)
                    {
                        min = nums[i];
                    }
                }
                return min;
            }

            // Ejercicio 4
            static void InsertAboveAvg(ref List<int> nums, int number)
            {
                float avg = 0f;
                foreach (int num in nums)
                {
                    avg += num;
                }
                avg /= nums.Count;

                Console.WriteLine("Average: " + avg);
                if (number > avg)
                {
                    Console.WriteLine("Adding: " + number);
                    nums.Add(number);
                }
                else
                    Console.WriteLine($"Number ({number}) below average, will not insert.");
            }

            // Ejercicio 5
            static void InsertIfNotPresent(ref List<int> nums, int number)
            {
                bool isPresent = false;

                foreach (int num in nums)
                {
                    if (num == number)
                    {
                        isPresent = true;
                    }
                }

                if (!isPresent)
                    nums.Add(number);
            }

            // Ejercicio 6
            static bool ValidateInt()
            {
                bool isInt = false;
                int num;

                Console.Write("Insert a number: ");
                string input = Console.ReadLine();

                isInt = int.TryParse(input, out num);

                return isInt ? true : false;
            }

            // Ejercicio 7
            static int[,] GetIdentityMatrix(int num)
            {
                int[,] matrix = new int[num, num];

                for (int r = 0; r < num; r++)
                {
                    for (int c = 0; c < num; c++)
                    {
                        if (r == c)
                        {
                            matrix[r, c] = 1;
                        }
                    }
                }

                return matrix;
            }
        }
    }
}
