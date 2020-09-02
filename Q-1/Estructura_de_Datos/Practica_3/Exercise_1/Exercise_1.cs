using System;

namespace Exercise_1
{
    class Program
    {
        public static void Main(String[] args)
        {
            int numero;

            int max = -100000;

            //Recibimos el numero por primera vez.
            numero = int.Parse(Console.ReadLine());

            //Si numero es diferente de -1, continuamos

            // ----- INICIO DEL LOOP -----
            while (numero != -1)
            {
                // es numero mayor a max?
                if (numero > max)
                {
                    //actualizamos max
                    max = numero;
                }

                /* obtenemos el proximo numero */
                numero = int.Parse(Console.ReadLine());

            }
            // ----- FIN DEL LOOP -----

            /*
            Para salir del loop, se debe ingresar el número -1 por consola, 
            ya que es la condición que rompe el loop.
            */

            /* escribimos el numero mas grande */
            Console.WriteLine("El numero mas grande es " + max);
        }

    }
}
