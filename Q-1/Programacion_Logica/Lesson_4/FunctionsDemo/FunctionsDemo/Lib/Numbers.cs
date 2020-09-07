using System;
namespace FunctionsDemo.Lib
{
    public class Numbers
    {
        public static bool IsPrime(int num)
        {
            bool isPrime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
