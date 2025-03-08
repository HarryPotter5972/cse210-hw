using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.Write("Do you want to play a game of Guess the Magic Number? ");
        string play = Console.ReadLine();
        while (play == "Yes" || play == "yes")
        {
            Random magicNumber = new Random ();
            int number = magicNumber.Next(1,100);
            int numberGuesses = 0;
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int guessInt = int.Parse(guess);
            while (guessInt != number)
            {
                if (guessInt > number)
                {
                    Console.WriteLine("Lower");
                    numberGuesses += 1;
                    Console.Write("What is your guess? ");
                    guess = Console.ReadLine();
                    guessInt = int.Parse(guess);
                }
                else
                {
                    Console.WriteLine("Higher");
                    numberGuesses += 1;
                    Console.Write("What is your guess? ");
                    guess = Console.ReadLine();
                    guessInt = int.Parse(guess);
                }
            }
            Console.WriteLine($"You guessed the magic number right! It is {number}! You guessed it in {numberGuesses} guesses.");
            Console.Write("Do you want to play again? ");
            Console.ReadLine();
        }
    }
}