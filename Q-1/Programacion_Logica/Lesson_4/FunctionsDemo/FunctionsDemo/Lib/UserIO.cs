using System;

namespace FunctionsDemo.Lib
{
    public class UserIO
    {
        public static void ShowResult(bool isPrime, int number)
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

        public static bool AskForNumber(out int num) // out specifies that the value of num will be exported
        {
            Console.WriteLine("Please enter a number:");
            bool isNumber = int.TryParse(Console.ReadLine(), out num);
            return isNumber;
        }
    }
}
