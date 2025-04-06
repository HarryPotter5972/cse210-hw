using System;

public class BreathingActivity : Activity
{
    
    public void ActivityBreathing()
    {
        Console.Write("Get ready...");
        
        ShowSpinner(5);
        Console.WriteLine();
        Run();
    }
    private void Run()
    {
        List<string> inhaleExhale = new List<string>();
        inhaleExhale.Add("Inhale...");
        inhaleExhale.Add("Exhale...");
        int index = 0;
        while (DateTime.Now < startTime.AddSeconds(_duration))
        {
            Console.Write(inhaleExhale[index]);
            ShowCountDown(5);
            index++;
            Console.WriteLine("");
            if (index >= inhaleExhale.Count)
            {
                index = 0;
            }
        }
    }
}