using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Exercise Log Program");
        List<Exercise> exercises = new List<Exercise>();

        Running exercise1 = new Running("15 Apr 2025", "Running", "45", "50 miles");
        exercises.Add(exercise1);

        Cycling exercise2 = new Cycling("12 Apr 2025", "Cycling", "70", "35");
        exercises.Add(exercise2);

        Swimming exercise3 = new Swimming("9 Mar 2025", "Swimming", "60", "60");
        exercises.Add(exercise3);

        foreach (Exercise exercise in exercises)
        {
            exercise.GetSummary();
        }
    }
}