using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int varA = 50;
            int varB = 99;
            int buffer;

            Console.WriteLine($"Before swapping values: varA = {varA}, varB = {varB}");
            buffer = varA;
            varA = varB;
            varB = buffer;

            Console.WriteLine($"After swapping: varA = {varA}, varB = {varB}");
        }
    }
}
