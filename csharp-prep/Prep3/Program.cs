using System;

class Program
{
    static void Main(string[] args)
    {

        // Console.Write("What is the magic number? ");
        // magicNumber = int.Parse(Console.ReadLine());
        string keepPlaying = "Yes";
        
        Console.WriteLine("Welcome to the guessing game!");

        while (keepPlaying == "Yes")
        {
            Random randomNumber = new Random();
            int magicNumber = randomNumber.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;
                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.WriteLine($"It took you {guessCount} guesses.");
            Console.Write("Would you like to play again? ");
            keepPlaying = Console.ReadLine();
        }
    }
}