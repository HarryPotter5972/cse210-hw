using System;
public class EternalGoal : Goal
{
    private int _numberAchieved;
    public EternalGoal(string name, string goalType, string description, int points) : base (name, goalType, description, points)
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
            _points = "50";
        }
        else
        {
            Console.WriteLine("Go do it then.");
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
    public override void SetCompletion(string numCompleted)
    {
        _numberAchieved = int.Parse(numCompleted);
    }
}