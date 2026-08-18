using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game();
        }

        static void Game()
        {
            List<string> Player = new List<string> { "Player1", "Player2" };

            int[] array1 = [5, 4, 3, 2, 1];

            Console.WriteLine("Countdown:");

            foreach (int value in array1)
            {
                Console.WriteLine(value);
                Thread.Sleep(1000);
            }

            Console.WriteLine("bomb");

            Bomb_Check(Player);

            Console.WriteLine("Spieler:");

            foreach (string player in Player)
            {
                Console.WriteLine(player);
            }
        }

        static void Bomb_Check(List<string> Player)
        {
            string input = Console.ReadLine();

            if (input == "bomb")
            {
                Player.Clear();
            }
        }
    }
}