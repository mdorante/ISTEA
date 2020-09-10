using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] greetings = { "Hello", "Hola", "Ciao", "Konichiwa", "Hallo" };

            ShowArray(greetings);
        }

        static void ShowArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"[{i}] -> {arr[i]}");
            }
        }
    }
}
