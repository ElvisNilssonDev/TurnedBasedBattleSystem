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
        }

        public void TakeDamagae(int damage)
        {
            currentHp -= damage;

        }
    }
}
