using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace ConsoleApp3
{
    internal class Program
    {
        private static Random r = new Random();
        

        static void Main(string[] args)
        {
            Game();
        }


        static void Game()
        {

            Console.WriteLine("Player Names:");
            Console.WriteLine("");


            List<string> Player = new List<string> { "Alexander", "Maximilian", "Leon", "Elias", "Noah", "Felix", "Jonas", "Luca", "Paul", "Ben", "Finn", "Moritz", "Emil", "Louis", "Theo", "David", "Julian", "Tim", "Nico", "Tom", "Jan", "Lukas", "Simon", "Erik", "Adrian", "Matteo", "Daniel", "Philipp", "Jakob", "Samuel", "Henry", "Anton", "Vincent", "Oskar", "Jonathan", "Max", "Florian", "Robin", "Marcel", "Tobias", "Clara", "Emma", "Mia", "Sophia", "Hannah", "Lina", "Laura", "Emilia", "Anna", "Marie" };

            int rInt = r.Next(0, 9);

            string[] players = new string[10];

            for (int i = 0; i< 10; i++)
            {
                rInt = r.Next(0, Player.Count);

                players[i] = Player[rInt];

                Player.RemoveAt(rInt);
            }

            Random rng = new Random();

            int zufallsZahl = rng.Next(10000, 99999);

            Console.WriteLine("Player 1:    " + players[0]);
            Console.WriteLine("Player 2:    " + players[1]);
            Console.WriteLine("Player 3:    " + players[2]);
            Console.WriteLine("Player 4:    " + players[3]);
            Console.WriteLine("Player 5:    " + players[4]);
            Console.WriteLine("Player 6:    " + players[5]);
            Console.WriteLine("Player 7:    " + players[6]);
            Console.WriteLine("Player 8:    " + players[7]);
            Console.WriteLine("Player 9:    " + players[8]);
            Console.WriteLine("Player 10:   " + players[9]);
            Console.WriteLine("");
            Console.Write("Bomb Code:   ");
            Console.WriteLine(zufallsZahl);
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

                            int counter = 0;

                            while (input != zufallsZahl)
                            {
                                if (is_first_try)
                                {
                                    Console.WriteLine();
                                    DisplayMaxTriesWarning();
                                    Console.WriteLine();
                                    Console.WriteLine("Code eingeben: ");
                                    is_first_try = false;
                                }
                                else
                                {
                                    counter++;
                                    Console.Write("Versuche:    ");
                                    Console.WriteLine(counter);
                                    Console.WriteLine("Code erneut eingeben: ");

                                    if (counter > 3)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine();
                                        DisplayTooManyTries();
                                        Console.WriteLine();

                                        int[] array2 = [3, 2, 1];

                                        Console.WriteLine("Shutdown:    ");

                                        foreach (int value in array2)
                                        {
                                            Console.WriteLine(value);
                                            Thread.Sleep(1000);
                                        }
                                        Environment.Exit(0);
                                    }
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

            Console.WriteLine();
            Console.WriteLine("+====================================+");
            Console.WriteLine("|            BOMB EXPLODED           |");
            Console.WriteLine("|              GAME OVER             |");
            Console.WriteLine("+====================================+");
            Console.WriteLine();
            //richtiger player als dead anzeigen 
            PlayerDead(13, 2, "dead     ");
            Thread.Sleep(30000);


        }

        private static void DisplayMaxTriesWarning()
        {
            Console.WriteLine("+---------------------------+");
            Console.WriteLine("|       WARNING             |");
            Console.WriteLine("|   MAX. 3 VERSUCHE!        |");
            Console.WriteLine("+---------------------------+");
        }

        private static void DisplayTooManyTries()
        {
            Console.WriteLine("+----------------------------------+");
            Console.WriteLine("|         ZU VIELE VERSUCHE        |");
            Console.WriteLine("|          ZUGRIFF GESPERRT        |");
            Console.WriteLine("+----------------------------------+");
        }

         public static void PlayerDead(int column, int zeile, string neuerText)
         {
            Console.SetCursorPosition(column, zeile);
            Console.WriteLine(neuerText);
         }
    }

}