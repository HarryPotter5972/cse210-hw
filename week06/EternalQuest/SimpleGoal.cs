using System;
using System.ComponentModel;
public class SimpleGoal : Goal
{
    protected bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        
    }
    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete(string input)
    {
        if (input == "Yes")
        {
            _isComplete = true;
        }
        else
        {
            _isComplete = false;
        }

        return _isComplete;
    }
    public override string GetDetailsString()
    {
        return $"{_shortName};{_description}; {_isComplete}";
    }
    public override string GetStringRepresentaion()
    {
        return base.GetStringRepresentaion();
    }
}