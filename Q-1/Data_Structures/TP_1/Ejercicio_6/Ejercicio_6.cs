using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bienvenida al juego + evento de batalla
            Console.WriteLine("\\_|_/ Dungeons and Dragons \\_|_/\n");
            Console.WriteLine("Te has conseguido a un enemigo!\n");

            Random rnd = new Random();

            // Atributos del personaje
            float fuerza = rnd.Next(1, 100);
            float agilidad = rnd.Next(1, 100);
            float aguante = rnd.Next(1, 100);
            float fuerzaDelArma = rnd.Next(1, 100);
            float pesoDelArma = rnd.Next(1, 100);
            float attack;


            // Atributos del enemigo
            float aguanteEnemy = rnd.Next(1, 100);
            float agilidadEnemy = rnd.Next(1, 100);
            float escudoEnemy = rnd.Next(1, 100);
            float vidaEnemy = rnd.Next(1, 100);
            bool enemyAlive = true;

            // calculamos el attack
            attack = (fuerza + agilidad) - (pesoDelArma % aguante);

            if (attack <= 0)
            {
                attack = 0;
            }
            if (pesoDelArma % fuerzaDelArma == 0)
            {
                attack *= 1.03f;
            }
            if (fuerza < pesoDelArma)
            {
                attack *= 0.98f;
            }

            // lanzamos los dados
            int dadoPunteria = rnd.Next(1, 7);
            int dadoSuerte = rnd.Next(1, 7);

            if (dadoPunteria % 2 == 0)
            {
                attack += dadoPunteria;
            }
            else
            {
                attack -= dadoPunteria;
            }

            if (dadoSuerte >= 5)
            {
                escudoEnemy = 0;
            }

            // Calculamos los puntos de defensa del enemigo
            float defensaEnemy = (aguanteEnemy * agilidadEnemy) + escudoEnemy * 1.5f; // escudoEnemy * 1.5f == escudoEnemy + escudoEnemy * 0.5f

            // Calculamos el damage que le infligimos al enemy
            float damage = attack - defensaEnemy;
            if (damage < 0)
            {
                damage = 0;
            }

            // Le restamos vida al enemigo
            vidaEnemy -= damage;
            if (vidaEnemy <= 0)
            {
                enemyAlive = false;
            }

            // Notificamos al jugador los stats del turno
            Console.WriteLine($"Tus puntos de ataque: {attack}");
            Console.WriteLine($"Puntos de defensa del enemigo: {defensaEnemy}\n");

            Console.WriteLine("[Atacaste al enemigo]\n");
            Console.WriteLine($"Vida del enemigo: {vidaEnemy}");

            if (enemyAlive == false)
            {
                Console.WriteLine("Tu enemigo ha muerto.");
            }

            // Fin del turno
            Console.ReadLine();

        }
    }
}
