using System;
using FunctionsDemo.Lib;

namespace FunctionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Script that determines if a number is prime or not
            // Separated into functions (or methods)

            int number;
            bool isNumber = UserIO.AskForNumber(out number);

            if (isNumber)
            {
                bool isPrime = Numbers.IsPrime(number);
                UserIO.ShowResult(isPrime, number);
            }
            else
            {
                Console.WriteLine("You did not enter a number.");
            }
        }
    }
}
