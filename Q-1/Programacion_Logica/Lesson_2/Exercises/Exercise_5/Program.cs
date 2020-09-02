using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto (lo que sea):");
            string text = Console.ReadLine();

            int num = 0;
            bool isNum = false;
            while (isNum == false || num > text.Length)
            {
                Console.WriteLine("Ingrese el numero a partir del cual quiere cortar el texto:");
                isNum = int.TryParse(Console.ReadLine(), out num);
            }

            Console.WriteLine(text.Substring(num - 1));
        }
    }
}
