using System;

namespace Exercise_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("PI (sin decimales) multiplicado por dos es igual a: ");
            Console.Write(TwoPiNoDecimals());
        }

        static int TwoPiNoDecimals()
        {
            return (int)Math.PI * 2;
        }
    }
}
