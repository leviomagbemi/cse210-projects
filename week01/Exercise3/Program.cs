using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while(playAgain == "yes")
        {
            int magicNumber;
            int guessNumber;
            int guessCount = 0;

            do
            {
                Random randomGenerator = new Random();
                magicNumber = randomGenerator.Next(1, 101);
                Console.WriteLine(magicNumber);

                Console.Write("What is your guess number? ");
                guessNumber = int.Parse(Console.ReadLine());

                guessCount += 1;

                if (magicNumber > guessNumber)
                {
                    Console.WriteLine("Guess higher");
                }
                else if (magicNumber < guessNumber)
                {
                    Console.WriteLine("Guess lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! You made {guessCount} guesses");

                    Console.Write("Do you want to continue playing(Yes/No)? ");
                    playAgain = Console.ReadLine().ToLower();
                }
            } while(magicNumber != guessNumber);
        }
    }
}