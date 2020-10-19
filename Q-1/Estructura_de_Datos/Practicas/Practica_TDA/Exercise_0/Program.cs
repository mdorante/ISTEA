using System;
using Exercise_0.Lib;
using Exercise_0.Lib.Characters;

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
            Player player = new Player();

            // Generamos aleatoriamente los atributos del enemigo (todos los enemigos van a tener atributos diferentes)
            Enemy enemy = new Enemy();

            // calculamos el attack
            player.attack = DungeonsEvents.AttackPoints(player.fuerza, player.agilidad, player.pesoDelArma, player.fuerzaDelArma, player.aguante);

            // Calculamos los puntos de defensa del enemigo
            enemy.defense = DungeonsEvents.EnemyDefensePoints(enemy.aguante, enemy.agilidad, enemy.escudo);

            // Notificamos al jugador los stats del turno
            Console.WriteLine($"Tus puntos de ataque: {player.attack}");
            Console.WriteLine($"Puntos de defensa del enemigo: {enemy.defense}");
            Console.WriteLine($"Vida del enemigo: {enemy.vida}" + '\n');

            // Calculamos el damage que le infligimos al enemigo
            float damage = DungeonsEvents.CalculateDamage(player.attack, enemy.defense);

            // Atacamos al enemigo
            enemy.alive = DungeonsEvents.InflictDamage(enemy.vida, damage);

            Console.WriteLine("[Atacaste al enemigo]" + '\n');
            Console.WriteLine($"Vida del enemigo: {enemy.vida}");

            if (!enemy.alive)
            {
                Console.WriteLine("Tu enemigo ha muerto.");
            }

            // Fin del turno
            Console.WriteLine("Fin del turno.");
            Console.ReadLine();

        }
    }
}