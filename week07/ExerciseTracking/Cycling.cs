using System;
public class Cycling : Exercise
{
    private double _speed;
    public Cycling(string date, string exerciseType, string lengthExercise, string speed): base (date, exerciseType, lengthExercise)
    {
        _speed = double.Parse(speed);
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        double distance = GetDistance();
        return _lengthExerciseTime/distance;
    }
    public override double GetDistance()
    {
        double milesPerMinute = _speed/60;
        double distance = milesPerMinute*_lengthExerciseTime;
        return distance;
    }
}