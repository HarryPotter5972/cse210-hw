using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int sum = 0;
        int average = 0;
        int largest = 0;
        Console.WriteLine("Enter a list of Numbers, type 0 when finished.");
        Console.Write("Enter a number: ");
        string newNumber = Console.ReadLine();
        int numInt = int.Parse(newNumber);
        while (numInt != 0)
        {
            numbers.Add(numInt);
            sum += numInt;
            if (numInt > largest)
            {
                largest = numInt;
            }
            average = sum / numbers.Count;
            Console.Write("Choose another number: ");
            newNumber = Console.ReadLine();
            numInt = int.Parse(newNumber);
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}