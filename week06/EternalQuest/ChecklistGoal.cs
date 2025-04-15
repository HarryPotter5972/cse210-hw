using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public override void RecordEvent()
    {
        Console.Write("Did you do this another time? ");
        string reply = Console.ReadLine();
        if (reply == "yes")
        {
            _amountCompleted += 1;
            bool completionStatus = IsComplete();
            if (completionStatus == true)
            {
                Console.WriteLine("Congrats! you completed");
            }
        }
    }
    public override bool IsComplete()
    {
        bool complete;
        if (_amountCompleted >= _target)
        {
            complete = true;
        }
        else
        {
            complete = false;
        }
        return complete;
    }
    public override string GetDetailsString()
    {
        return "";
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}