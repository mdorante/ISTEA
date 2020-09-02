using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra:");
            string word1 = Console.ReadLine();

            Console.WriteLine("Ingrese otra palabra:");
            string word2 = Console.ReadLine();

            if (word1.Length > word2.Length)
            {
                Console.WriteLine($"{word1} ({word1.Length}) tiene mas caracteres que {word2} ({word2.Length})");
            }
            else if (word1.Length < word2.Length)
            {
                Console.WriteLine($"{word2} ({word2.Length}) tiene mas caracteres que {word1} ({word1.Length})");
            }
            else
            {
                Console.WriteLine($"{word2} y {word1} tienen la misma cantidad de caracteres ({word1.Length})");
            }
        }
    }
}
