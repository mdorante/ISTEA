using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;

            while (word != "chau")
            {
                Console.WriteLine("Por favor, ingrese una palabra:");
                word = Console.ReadLine();

                if (word != "chau")
                {
                    Console.WriteLine(word); // para evitar que haga eco de la palabra "chau", ahi deberia directamente salir del loop
                }
            }

            Console.WriteLine("Adios!");
        }
    }
}
