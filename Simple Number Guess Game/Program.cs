using System;

namespace Simple_Number_Guess_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zum Ratespiel!");
            Console.WriteLine("Ich habe eine Zahl zwischen 1 und 100 gewählt.");
            Console.WriteLine("Versuche die Zahl zu erraten.");

            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            int userGuess = 0;
            int attempts = 0;

            while (userGuess != numberToGuess)
            {
                Console.WriteLine("Gebe eine Zahl zwischen 1 und 100 ein: ");
                string input = Console.ReadLine();
                attempts++;

                if (!int.TryParse(input, out userGuess))
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte gib eine gültige Zahl ein");
                    continue;
                }
                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Zu Niedrig! Versuche es erneut.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Zu Hoch! Versuche es erneut.");
                }
                else
                {
                    Console.WriteLine("Richtig! Du hast " + attempts + " Versuche gebraucht.");
                }

            }
            if (attempts < 5)
            {
                Console.WriteLine("Nicht Schlecht!");
            }
            else if (attempts < 10)
            {
                Console.WriteLine("Ist OK");
            }
            else
            {
                Console.WriteLine("NOOB");
            }
        }
    }
}
