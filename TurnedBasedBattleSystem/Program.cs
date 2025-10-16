using TurnedBasedBattleSystem.Classes;

namespace TurnedBasedBattleSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unit player = new Unit(100, 20, 12, 10, "Player");
            Unit enemy = new Unit(80, 15, 10, 0, "Enemy");

            Console.WriteLine($"{player.UnitName} HP = {player.Hp}. {enemy.UnitName} HP {enemy.Hp}");
            Console.WriteLine("Its the players turn! What will you do?!");
            string choice = Console.ReadLine();

            if (choice == "a") 
                player.Attack(enemy);

            Console.WriteLine($"{player.UnitName} HP = {player.Hp}. {enemy.UnitName} HP {enemy.Hp}");
        }
    }
}
