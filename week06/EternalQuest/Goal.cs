using System;
using System.ComponentModel;
using System.Data;
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;
    protected string _goalType;
    protected string _completionStatus;

    protected Goal(string name, string goalType, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = $"{points}";
        _goalType = goalType;
        _completionStatus = "Incomplete";
    }
    public virtual void RecordEvent()
    {
        
    }
    public virtual bool IsComplete(string input)
    {
        return false;
    }
    public virtual string GetDetailsString()
    {
        return "";
    }
    public virtual string GetStringRepresentaion()
    {
        return "";
    }
    public virtual void SetCompletion(string numCompleted)
    {

    }
    public int getScore()
    {
        return int.Parse(_points);
    }
}