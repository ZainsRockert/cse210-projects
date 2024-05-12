using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("James", 1, 5, 6, "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. \nBut let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed. ");
        Console.Clear();
        scripture.Display();
        Console.WriteLine("\n-Press Enter to continue or type 'quit' to exit.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            if (!scripture.HideRandomWord())
            {
                Console.WriteLine("\nYou got this, you memorized the scripture!!");
                break;
            }

            Console.Clear();
            scripture.Display();
            Console.WriteLine("\n-Press Enter to continue or type 'quit' to exit.");
        }
    }
}

// I added some comments when the user finished the program.