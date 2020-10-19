using System;

namespace Exercise_0.Lib.Characters
{
    public class Enemy
    {
        public float aguante;
        public float agilidad;
        public float escudo;
        public float vida;
        public float defense;
        public bool alive;

        public Enemy()
        {
            Random rnd = new Random();
            this.aguante = rnd.Next(1, 100);
            this.agilidad = rnd.Next(1, 100);
            this.escudo = rnd.Next(1, 100);
            this.vida = rnd.Next(1, 100);
            this.alive = true;
        }

    }
}