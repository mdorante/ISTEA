using System;

namespace Exercise_2
{
    class Program
    {
        public static void Main(String[] args)
        {

            // Aqui contaremos los pares e impares
            int pares = 0;
            int impares = 0;

            // Aqui guardaremos los numeros
            int numero;

            // obtenemos el primer numero
            numero = int.Parse(Console.ReadLine());


            // 0 termina la ejecucion
            while (numero != 0)
            {
                // check if the number is odd
                if (numero % 2 != 0)
                {
                    // incrementa el contador de impares
                    impares++;
                }
                else
                {
                    // incrementa el contador de pares
                    pares++;
                }

                // obtenemos el proximo numero
                numero = int.Parse(Console.ReadLine());
            }
            // mostramos el resultado.
            Console.WriteLine("Numeros Pares: " + pares);
            Console.WriteLine("Numeros impares: " + impares);

        }

    }
}
