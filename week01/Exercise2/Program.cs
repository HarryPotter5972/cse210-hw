using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);
        int remainder = percentage%10;
        char letter = '\0';
        char plusMinus = '\0';
        if (percentage >= 90)
        {
            letter = 'A';
            Console.WriteLine($"You got a letter grade of {letter}!");
        }
        else if (90 > percentage && percentage >= 80)
        {
            letter = 'B';
        }
        else if (80 > percentage && percentage >= 70)
        {
            letter = 'C';
        }
        else if (70 > percentage && percentage >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        if (percentage >= 70)
        {
            Console.Write("You are passing the class! Keep up the good work! ");
        }
        else
        {
            Console.Write("You are failing the class, but you can do better." );
        }

        if (remainder >= 7 && (percentage <90 || percentage > 60))
        {
            plusMinus = '+';
        }
        else if (remainder < 3 && percentage > 60 && percentage != 100)
        {
            plusMinus = '-';
        }
        else
        {
            plusMinus = '\0';
        }
        Console.WriteLine($"You have a letter grade of {letter}{plusMinus}.");
    }
}