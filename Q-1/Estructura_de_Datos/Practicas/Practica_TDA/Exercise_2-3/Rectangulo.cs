using System;

namespace Exercise_2_3
{
    public class Rectangulo
    {
        public float baseRect;
        public float altura;
        public ConsoleColor color;

        public Rectangulo(float baseRect, float altura, ConsoleColor color)
        {
            this.baseRect = baseRect;
            this.altura = altura;
            this.color = color;
        }

        public float ObtenerArea()
        {
            return this.baseRect * this.altura;
        }

        public float ObtenerPerimetro()
        {
            return (2 * this.baseRect) + (2 * this.altura);
        }

        public void Dibujar()
        {
            Console.ForegroundColor = this.color;

            for (int i = 0; i < this.baseRect; i++)
            {
                for (int j = 0; j < this.altura; j++)
                {
                    if (i == 0 || i == this.baseRect - 1 || j == 0 || j == this.altura - 1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            return;
        }
    }
}