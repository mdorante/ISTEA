using System;
using Functions.Lib;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMessages.ShowTime();
            DisplayMessages.ShowTime("dddd, dd MMMM yyyy");

            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            int max = Numbers.Greatest(num1, num2);
            DisplayMessages.ShowMessage($"Between {num1} and {num2}, the greatest is {max}");
        }
    }
}
