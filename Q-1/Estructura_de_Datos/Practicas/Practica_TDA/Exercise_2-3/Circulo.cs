using System;

namespace Exercise_2_3
{
    public class Circulo
    {
        public const float PI = (float)Math.PI;
        public float radio;
        public ConsoleColor color;

        public Circulo(float radio, ConsoleColor color)
        {
            this.radio = radio;
            this.color = color;
        }
        public float ObtenerArea()
        {
            return PI * (float)Math.Pow(this.radio, 2);
        }

        public void Dibujar()
        {
            Console.ForegroundColor = this.color;
            for (int i = 0; i <= 2 * this.radio; i++)
            {
                for (int j = 0; j <= 2 * this.radio; j++)
                {
                    double dist = Math.Sqrt((i - this.radio) * (i - this.radio) + (j - this.radio) * (j - this.radio));
                    if (dist > this.radio - 0.5 && dist < this.radio + 0.5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            return;
        }
    }

}