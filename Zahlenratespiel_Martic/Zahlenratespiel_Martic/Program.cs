using System;

namespace Zahlenratespiel_Martic
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rand = new Random();
            Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 100 ein: ");
            int toGuess = Rand.Next(1, 100);
            int userInput;
            int Guesses = 1;

            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ungültige Eingabe, geben Sie was anderes ein:");
                Console.ForegroundColor = ConsoleColor.White;
            }

            while (userInput != toGuess)
            {
                
                while (userInput < 1 || userInput > 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ungültige Eingabe, geben Sie was anderes ein:");
                    Console.ForegroundColor = ConsoleColor.White;

                    while (!int.TryParse(Console.ReadLine(), out userInput))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ungültige Eingabe, geben Sie was anderes ein:");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.Clear();

                }

                Guesses++;

                if (userInput < toGuess)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Die Zufallszahl ist grösser als {userInput}.");
                    Console.ForegroundColor = ConsoleColor.White;

                    while (!int.TryParse(Console.ReadLine(), out userInput))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ungültige Eingabe, geben Sie was anderes ein:");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.Clear();
                }
                else if (userInput > toGuess)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Die Zufallszahl ist kleiner als {userInput}.");
                    Console.ForegroundColor = ConsoleColor.White;

                    while (!int.TryParse(Console.ReadLine(), out userInput))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ungültige Eingabe, geben Sie was anderes ein:");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.Clear();
                }

            }

                if (userInput == toGuess)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Herzlichen Glückwunsch! Die Zahl war {toGuess}.");
                }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Sie brauchten {Guesses} Versuche.");
            Console.ReadKey();
        }
    }
}
