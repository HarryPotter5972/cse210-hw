using System;

public class Exercise
{
    protected string _date ;
    protected double _lengthExerciseTime;
    private string _exerciseType;
    public Exercise(string date, string exerciseType, string lengthExercise)
    {
        _date = date;
        _lengthExerciseTime = int.Parse(lengthExercise);
        _exerciseType = exerciseType;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public void GetSummary()
    {
        double speed = GetSpeed();
        double pace = GetPace();
        double distance = GetDistance();
        Console.WriteLine($"{_date} {_exerciseType} ({_lengthExerciseTime} min) - Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile");
    }
}