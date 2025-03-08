using System;

class Program
{
    static void Main(string[] args)
    {
        HelloMessage();
        string nameuser = UsersName();
        int favNum = FavNumber();
        int SqNum = NumberSquared(favNum);
        Results(nameuser, favNum, SqNum);
    }
    static void HelloMessage()
    {
        Console.WriteLine("Hi there! Welcome to the program!");
    }
    static string UsersName()
    {
        Console.WriteLine("What is your name?");
        Console.Write("First Name: ");
        string FirstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string LastName = Console.ReadLine();
        string FullName = $"{FirstName} {LastName}";

        return FullName;
    }
    static int FavNumber()
    {
        Console.Write("What is your favorite number? ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }
    static int NumberSquared(int number)
    {
        int favNumberSquared = number * number;
        return favNumberSquared;
    }
    static void Results(string name, int number, int square)
    {
        Console.WriteLine($"{name}, a square with a length of your favorite number in feet, {number}, has an area of {square} square feet.");
    }
}