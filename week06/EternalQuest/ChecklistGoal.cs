using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    
    public ChecklistGoal(string name, string goalType, string description, int points, int target, int bonus) : base(name, goalType, description, points)
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
            bool completionStatus = IsComplete(reply);
            _points += 10;
            if (completionStatus == true)
            {
                Console.WriteLine("Congrats! you completed");
                _points += _bonus;
                _completionStatus= "Complete";
            }
        }
    }
    public override bool IsComplete(string input)
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
        return $"{_shortName};{_description};{_amountCompleted}/{_target};{_completionStatus}";
    }
    public override string GetStringRepresentaion()
    {
        return $"{_shortName},{_goalType},{_description},{_points},{_amountCompleted},{_target}, {_bonus},{_completionStatus}";
    }
    public override void SetCompletion(string numCompleted)
    {
        _amountCompleted = int.Parse(numCompleted);
        if (_amountCompleted == _target)
        {
            _completionStatus = "Complete";
        }
    }
}