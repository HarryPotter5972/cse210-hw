using System;
public class Swimming : Exercise
{
    private double _numberLaps;
    public Swimming(string date, string exerciseType, string lenghExercise, string numLaps) : base (date, exerciseType, lenghExercise)
    {
        _numberLaps = int.Parse(numLaps);
    }
    public override double GetSpeed()
    {
        double distance = GetDistance();
        double distanceOverDuration = distance/_lengthExerciseTime;
        double milesPerHour = distanceOverDuration * 60;
        return milesPerHour;
    }
    public override double GetPace()
    {
        double distance = GetDistance();
        return _lengthExerciseTime/distance;
    }
    public override double GetDistance()
    {
        Console.WriteLine(_numberLaps);
        double poolLengthFeet = 50 * 3.281; //Conversion to feet instead of kilometers. The conversion to kilometers kept on zeroing out.
        Console.WriteLine(poolLengthFeet);
        double poolLengthMiles = poolLengthFeet / 5280;
        double lengthLap = poolLengthMiles * 2; //What I think of as lap pools are ones that swimming athletes race in. That means I interpreted laps as crossing the length of the pool and back to the beginning. 
        double distance = lengthLap * _numberLaps;
        return distance;
    }
}