using System;
public class EternalGoal : Goal
{
    private int _numberAchieved;
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {

    }
    public override void RecordEvent()
    {
        Console.Write("Did you complete this goal again? ");
        string reply = Console.ReadLine();
        bool doneAgain = IsComplete(reply);
        if (doneAgain == true)
        {
            _numberAchieved =+ 1;
        }
        else
        {
            
        }
    }
    public override bool IsComplete(string reply)
    {
        bool completionStatus;
        if (reply == "Yes")
        {
            completionStatus = true;
        }
        else
        {
            completionStatus = false;
        }
        return completionStatus;
    }
}