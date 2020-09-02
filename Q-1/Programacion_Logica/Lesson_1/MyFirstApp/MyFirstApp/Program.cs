using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program asks the user to input two numbers and prints the sum

            Console.WriteLine("Enter a number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number:");
            int num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"The sum of these two numbers is: {num1 + num2}");
        }
    }
}
