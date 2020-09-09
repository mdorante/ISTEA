using System;

namespace Exercise_0
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            int number = 0;
            bool isNum = false;

            Console.WriteLine("Welcome, this script repeats a given word as many times as specified." + Environment.NewLine);

            Console.WriteLine("Please enter a word:");
            word = Console.ReadLine();

            while (!isNum)
            {
                Console.WriteLine("Please enter a number:");
                isNum = int.TryParse(Console.ReadLine(), out number);
            }

            Console.Write(Environment.NewLine);

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(word);
            }

        }
    }
}
