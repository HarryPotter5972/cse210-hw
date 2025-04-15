using System;
public class Running : Exercise
{
    private double _distance;
    public Running(string date,string exerciseType, string lengthExercise, string distance) : base (date, exerciseType, lengthExercise)
    {
        string[] parts = distance.Split(" ");
        _distance = int.Parse(parts[0]);
    }
    public override double GetSpeed()
    {
        double distanceOverDuration = _distance / _lengthExerciseTime;
        double milesPerHour = distanceOverDuration * 60;
        return milesPerHour;
    }
    public override double GetPace()
    {
        return _lengthExerciseTime/_distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
}