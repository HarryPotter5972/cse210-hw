using System;
using Microsoft.VisualBasic;

public class Activity
{
    private int _numberBreathing = 0;
    private int _numberReflecting = 0;
    private int _numberListing = 0;
    protected int _totalTimeSeconds = 0;
    private int _totalTImeMinutes = 0;
    private string _name;
    private string _description;
    protected int _duration;
    public DateTime startTime = DateTime.Now;
    public void Action()
    {
        Console.WriteLine("Main Menu");
        Console.WriteLine("    1. Breathing Activity");
        Console.WriteLine("    2. Reflecting Activity");
        Console.WriteLine("    3. Listing Activity");
        Console.WriteLine("    4. Quit");
        Console.Write("Select a choice from the menu: ");
        _name = Console.ReadLine();
        while (_name != "4" || _name != "Quit")
        {
            DisplayStartingMessage(_name);
        }
        if (_name == "4" || _name == "Quit")
        {
            Console.WriteLine($"You completed the Breathing Activity {_numberBreathing} times, the Reflecting Activity {_numberReflecting} times, and the Listing Activity {_numberListing} times. The total time spent on all activities is {_totalTImeMinutes} and {_totalTimeSeconds}.");
        }
    }
    private void DisplayStartingMessage(string active) //For Starting message
    {
        Console.Clear();
        if (active == "1" || active == "Breathing Activity")
        {
            _name = "Breathing Activity";
            Console.WriteLine($"Weldome to {_name}");
            BreathingActivity breathing = new BreathingActivity();
            _description = "This activity will help with relaxation through slow and controlled breathing to regulate blood pressure. Clear your mind and breath deeply";
            Console.WriteLine(_description);
            Console.Write("How long, in seconds, would you like for your session? ");
            string duration = Console.ReadLine();
            _duration = int.Parse(duration);
            breathing.ActivityBreathing();
            _numberBreathing += 1;
            _totalTimeSeconds += _duration;
            while (_totalTimeSeconds >= 60)
            {
                _totalTimeSeconds = _totalTimeSeconds - 60;
                _totalTImeMinutes += 1;
            }
            DisplayEndingMessage();
        }
        else if (active == "2" || active == "Reflecting Activity")
        {
            ReflectingActivity reflecting = new ReflectingActivity();
            _name = "Reflecting Activity";
            Console.WriteLine($"Welcome to {_name}");
            _description = "This activity will help with relaxation through reflection on situations in your life when you have shown strength and resilience. This will help you recognise the strength you have and how it can be implemented in other aspects of your life.";
            Console.WriteLine(_description);
            Console.Write("How long, in seconds, would you like for your session? ");
            string duration = Console.ReadLine();
            _duration = int.Parse(duration);
            reflecting.ActivityReflecting();
            _numberReflecting += 1;
            _totalTimeSeconds += _duration;
            while (_totalTimeSeconds >= 60)
            {
                _totalTimeSeconds = _totalTimeSeconds - 60;
                _totalTImeMinutes += 1;
            }
            DisplayEndingMessage();
        }
        else if (active == "3" || active == "Listing Activity")
        {
            ListingActivity listing = new ListingActivity();
            _name= "Listing Activity";
            Console.WriteLine($"Welcome to {_name}");
            _description = "This activity will help with relaxation by listing items by a random prompt.";
            Console.Write("How long in seconds would you like for this session? ");
            string duration = Console.ReadLine();
            _duration = int.Parse(duration);
            listing.ListActivity();
            _numberListing += 1;
            _totalTimeSeconds += _duration;
            while (_totalTimeSeconds >= 60)
            {
                _totalTimeSeconds = _totalTimeSeconds - 60;
                _totalTImeMinutes += 1;
            }
            DisplayEndingMessage();

        }
    }
    public void DisplayEndingMessage() //For showing End Message
    {
        Console.WriteLine("Well Done!!!!!");
        Console.WriteLine($"You did another {_duration} seconds of {_name}");
        ShowSpinner(70);
        Console.Clear();
        Action();
    }
    public void ShowSpinner(int seconds) //For showing spinner
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        int index = 0;
        DateTime endtime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endtime)
        {
            string s = spinner[index];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            index +=1;
            if (index > spinner.Count)
            {
                index = 0;
            }
            
        }

    }
    public void ShowCountDown(int seconds)
    {
        for (int second = seconds; second > 0; second--)
        {
            Console.Write(second);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
    }
}