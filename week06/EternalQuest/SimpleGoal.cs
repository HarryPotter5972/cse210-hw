using System;
using System.ComponentModel;
public class SimpleGoal : Goal
{
    protected bool _isComplete;
    public SimpleGoal(string name, string goalType, string description, int points) : base (name, goalType, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        Console.Write("Did you complete this goal?" );
        string reply = Console.ReadLine();
        bool completionStatus = IsComplete(reply);
        if (completionStatus == true)
        {
            _points += 50;
            _isComplete = true;
            Console.WriteLine($"Congrats on completing {_shortName}!");
        }
        else
        {
            _isComplete = false;
            Console.WriteLine("You haven't completed this goal yet");
        }
    }
    public override bool IsComplete(string input)
    {
        bool complete;
        if (input == "Yes")
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
        return $"{_shortName};{_description};{_completionStatus}";
    }
    public override string GetStringRepresentaion()
    {
        return $"{_shortName},{_goalType},{_description},{_points}, {_completionStatus}";
    }
    public override void SetCompletion(string numcompleted)
    {
        _isComplete = true;
        _completionStatus = "Complete";
    }
}