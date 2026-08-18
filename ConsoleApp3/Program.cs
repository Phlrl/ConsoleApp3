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

            Console.WriteLine("Name Players");



            string Player1;
            string Player2;


            List<string> Player = new List<string> { "Jonas", "Mia", "Leon", "Sophie", "Felix", "Clara", "Elias", "Hannah", "Lukas", "Emma" };

            Random r = new Random();
            int rInt = r.Next(0, 9);

            Player1 = Player[rInt];

            rInt = r.Next(0, 9);

            Player2 = Player[rInt];

            Console.WriteLine("Player 1:");
            Console.WriteLine(Player1);
            Console.WriteLine("Player 2:");
            Console.WriteLine(Player2);

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