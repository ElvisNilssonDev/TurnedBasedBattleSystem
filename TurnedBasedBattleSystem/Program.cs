using TurnedBasedBattleSystem.Classes;

namespace TurnedBasedBattleSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unit player = new Unit(100,125, 12, 10, "Hero");
            Unit enemy = new Unit(80,90, 10, 0, "Enemy Mage");
            Random random = new Random();
            
            while(!player.IsDead && !enemy.IsDead)
            {
                Console.WriteLine($"{player.UnitName} HP = {player.Hp}. {enemy.UnitName} HP {enemy.Hp}");
                Console.WriteLine("Its the Heros turn! What will you do?!");
                Console.WriteLine("Press |a| to deal damage or press any other to heal!");
                string choice = Console.ReadLine();

                if (choice == "a")
                    player.Attack(enemy);
                else
                    player.Heal();

                if (player.IsDead || enemy.IsDead) break;

                Console.WriteLine($"{player.UnitName} HP = {player.Hp}. {enemy.UnitName} HP {enemy.Hp}");

                Console.WriteLine("Its the enemys turn!");

                int rand = random.Next(0, 2);

                if (rand == 0)
                    enemy.Attack(player);
                else
                    enemy.Heal();
                
            }
            
        }
    }
}
