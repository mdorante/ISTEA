using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "Player1";
            string password = "SuperSecretPassword";

            string[] creds = PedirCreds();


            while (creds[0] != username || creds[1] != password)
            {
                Console.WriteLine("Algun dato es incorrecto, por favor intente de nuevo.");
                creds = PedirCreds();
            }

            // Ya salimos del loop, asi que creds[0] == username
            Console.WriteLine($"Bienvenido {creds[0]}!");
        }

        static string[] PedirCreds()
        {
            string[] creds = new string[2];

            Console.WriteLine("Ingrese su su nombre de usuario:");
            creds[0] = Console.ReadLine();

            Console.WriteLine("Ingrese su contraseña:");
            creds[1] = Console.ReadLine();

            return creds;
        }
    }
}
