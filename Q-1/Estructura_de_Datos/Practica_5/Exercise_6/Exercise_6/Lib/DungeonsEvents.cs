using System;

namespace Exercise_6.Lib
{
    public class DungeonsEvents
    {
        public static float[] NewEnemy()
        {
            Random rnd = new Random();

            float[] enemy = new float[4];

            for (int i = 0; i < enemy.Length; i++)
            {
                enemy[i] = rnd.Next(1, 100);
            }

            return enemy;
        }

        public static float AttackPoints(float fuerza, float agilidad, float pesoDelArma, float fuerzaDelArma, float aguante)
        {
            int dadoPunteria = DungeonsEvents.RollDice();

            float attack = (fuerza + agilidad) - (pesoDelArma % aguante);

            if (pesoDelArma % fuerzaDelArma == 0)
            {
                attack *= 1.03f;
            }
            if (fuerza < pesoDelArma)
            {
                attack *= 0.98f;
            }

            if (dadoPunteria % 2 == 0)
            {
                attack += dadoPunteria;
            }
            else
            {
                attack -= dadoPunteria;
            }

            return attack;
        }

        public static float EnemyDefensePoints(float aguante, float agilidad, float escudo)
        {
            int dadoSuerte = DungeonsEvents.RollDice();

            if (dadoSuerte >= 5)
            {
                escudo = 0;
            }

            float defensa = (aguante * agilidad) + escudo * 1.5f;

            return defensa;
        }

        public static float CalculateDamage(float attack, float enemyDefense)
        {
            float damage = attack - enemyDefense;

            if (damage < 0)
            {
                damage = 0;
            }

            return damage;
        }

        public static bool InflictDamage(float enemyLife, float damage)
        {
            bool alive = true;

            enemyLife -= damage;

            if (enemyLife <= 0)
            {
                alive = false;
            }

            return alive;
        }

        private static int RollDice()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
    }
}
