using System;

public class Job
{
    public string _jobName;
    public string _buisness;
    public string _yearStart;
    public string _yearEnd;

    public void DisplayDetails()
    {
        Console.WriteLine($"{_jobName} ({_buisness}) {_yearStart}-{_yearEnd}");
    }
}