using System;

class Program()
{
    static void Main(string[] args)
    {
        Fraction firstFraction = new Fraction();
        firstFraction.BuildFraction();
        Console.WriteLine(firstFraction.FractionString());
        Console.WriteLine(firstFraction.DecimalValue());

        Fraction secondFraction = new Fraction();
        string numerator = Console.ReadLine();
        int Numerator = firstFraction.GetNumerator(numerator);
        
        Console.WriteLine(secondFraction.FractionString());
        Console.WriteLine(secondFraction.DecimalValue());

        Fraction thirdFraction = new Fraction(59, 72);
        Console.WriteLine(thirdFraction.FractionString());
        Console.WriteLine(thirdFraction.DecimalValue());

        Fraction fourthFraction = new Fraction(1, 3);
        Console.WriteLine(fourthFraction.FractionString());
        Console.WriteLine(fourthFraction.DecimalValue());
    }
}