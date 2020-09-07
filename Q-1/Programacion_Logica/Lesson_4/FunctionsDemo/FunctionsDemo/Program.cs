using System;

namespace FunctionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Script that determines if a number is prime or not
            // Separated into functions (or methods)

            int number;
            bool isNumber = AskForNumber(out number);

            if (isNumber)
            {
                bool isPrime = IsPrime(number);
                ShowResult(isPrime, number);
            }
            else
            {
                Console.WriteLine("You did not enter a number.");
            }

            static void ShowResult(bool isPrime, int number)
            {
                if (isPrime)
                {
                    Console.WriteLine($"{number} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a prime number.");
                }
            }

            static bool AskForNumber(out int num) // out specifies that the value of num will be exported
            {
                Console.WriteLine("Please enter a number:");
                bool isNumber = int.TryParse(Console.ReadLine(), out num);
                return isNumber;
            }

            static bool IsPrime(int num)
            {
                bool isPrime = true;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                return isPrime;
            }
        }
    }
}
