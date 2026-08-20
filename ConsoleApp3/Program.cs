using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;

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

            Console.WriteLine("Player Names:");
            Console.WriteLine("");

            string Player1;
            string Player2;

            List<string> Player = new List<string> { "Jonas", "Mia", "Leon", "Sophie", "Felix", "Clara", "Elias", "Hannah", "Lukas", "Emma" };

            Random r = new Random();
            int rInt = r.Next(0, 9);

            Player1 = Player[rInt];

            rInt = r.Next(0, 9);

            Player2 = Player[rInt];

            int pass;

            List<int> code = new List<int> { 58321, 91467, 26053, 74819, 13582, 69240, 82756, 40193, 57608, 31974 };

            Random n = new Random();
            int nInt = n.Next(0, 10);

            pass = code[nInt];


            Console.Write("Player 1:    ");
            Console.WriteLine(Player1);
            Console.Write("Player 2:    ");
            Console.WriteLine(Player2);
            Console.WriteLine("");
            Console.Write("Bomb Code:   ");
            Console.WriteLine(pass);
            Console.WriteLine("");

            string auswahl = "";

            while (auswahl != "1")

            {
                Console.WriteLine("Auswahl:");
                Console.WriteLine("");
                Console.WriteLine("1 = Place Bomb");
                Console.WriteLine("2 = Wait");

                auswahl = Console.ReadLine();

                switch (auswahl)
                {
                    case "1":
                        if (auswahl == "1")
                        {
                            int input = 0;
                            bool is_first_try = true;

                            while (input != pass)
                            {
                                if (is_first_try)
                                {
                                    Console.WriteLine("Code eingeben: ");
                                    is_first_try = false;
                                }
                                else
                                {
                                    Console.WriteLine("Code erneut eingeben: ");

                                }
                                input = Convert.ToInt32(Console.ReadLine());
                                    
                            }
                            Console.WriteLine("Bomb Placed");
                        }
                    break;

                    case "2":
                        if (auswahl == "2")
                        {
                            Console.WriteLine("es wird gewartet");

                        }
                        break;

                    default:
                        Console.WriteLine("Ungueltige Auswahl");
                        break;
                }
            }


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