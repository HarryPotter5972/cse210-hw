using System;
using System.ComponentModel;
using System.Data;
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    protected Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = $"{points}";
    }
    public virtual void RecordEvent()
    {
        
    }
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual string GetDetailsString()
    {
        return $"{_shortName};{_description};{_points}";
    }
    public virtual string GetStringRepresentaion()
    {
        return "";
    }
}