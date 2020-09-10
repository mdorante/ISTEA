using System;
using Exercise_6.Lib;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bienvenida al juego + evento de batalla
            Console.WriteLine("\\_|_/ Dungeons and Dragons \\_|_/" + '\n');
            Console.WriteLine("Te has conseguido a un enemigo!" + '\n');



            // Atributos del personaje
            float fuerza = 87f;
            float agilidad = 62f;
            float aguante = 74f;
            float fuerzaDelArma = 79f;
            float pesoDelArma = 70f;
            float attack;

            // Generamos aleatoriamente los atributos del enemigo (todos los enemigos van a tener atributos diferentes)
            float[] enemy = DungeonsEvents.NewEnemy();
            float aguanteEnemy = enemy[0];
            float agilidadEnemy = enemy[1];
            float escudoEnemy = enemy[2];
            float vidaEnemy = enemy[3];
            bool enemyAlive;

            // calculamos el attack
            attack = DungeonsEvents.AttackPoints(fuerza, agilidad, pesoDelArma, fuerzaDelArma, aguante);

            // Calculamos los puntos de defensa del enemigo
            float defensaEnemy = DungeonsEvents.EnemyDefensePoints(aguanteEnemy, agilidadEnemy, escudoEnemy);

            // Notificamos al jugador los stats del turno
            Console.WriteLine($"Tus puntos de ataque: {attack}");
            Console.WriteLine($"Puntos de defensa del enemigo: {defensaEnemy}" + '\n');

            // Calculamos el damage que le infligimos al enemigo
            float damage = DungeonsEvents.CalculateDamage(attack, defensaEnemy);

            // Atacamos al enemigo
            enemyAlive = DungeonsEvents.InflictDamage(vidaEnemy, damage);

            Console.WriteLine("[Atacaste al enemigo]" + '\n');
            Console.WriteLine($"Vida del enemigo: {vidaEnemy}");

            if (!enemyAlive)
            {
                Console.WriteLine("Tu enemigo ha muerto.");
            }

            // Fin del turno
            Console.WriteLine("Fin del turno.");
            Console.ReadLine();

        }
    }
}
