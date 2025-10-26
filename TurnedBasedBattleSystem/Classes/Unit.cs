using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnedBasedBattleSystem.Classes
{
    internal class Unit
    {
        private int currentHp;
        private int maxHp;
        private int attackPower;
        private int healPower;
        private string unitName;
        private Random random;

        public int Hp { get { return currentHp; } }

        public string UnitName { get { return unitName; } }

        public bool IsDead { get { return currentHp <= 0; } }

        public Unit(int currentHp, int maxHp, int attackPower, int healPower, string unitName)
        {
            this.currentHp = currentHp;
            this.maxHp = maxHp;
            this.attackPower = attackPower;
            this.healPower = healPower;
            this.unitName = unitName;
            this.random = new Random();
        }

        public void Attack(Unit unitToAttck)
        {
            double rng = random.NextDouble();
            rng = rng / 2+ 0.75f;
            int randDamage = (int)(attackPower * rng);
            unitToAttck.TakeDamagae(randDamage);
            Console.WriteLine($"{unitName} attacks {unitToAttck.unitName} and deals {randDamage} Damage!");
            Console.WriteLine("Press to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public void TakeDamagae(int damage)
        {
            currentHp -= damage;

            if(IsDead)
                Console.WriteLine($"{unitName} has been defeated!");

        }

        public void Heal()
        {
            double rng = random.NextDouble();
            rng  = rng / 2 + 0.75f;
            int heal = (int)(healPower * rng);
            currentHp = heal + currentHp > maxHp ? maxHp : currentHp + heal;
            Console.WriteLine($"{unitName} heals for {heal} HP!");
            Console.WriteLine("Press to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
