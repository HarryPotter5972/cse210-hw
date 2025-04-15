using System.IO;
using System.ComponentModel.Design;
using System.Globalization;

public class GoalManager
{
    
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public void Start()
    {
        Console.WriteLine("Main Menu");
        Console.WriteLine("1. Player Info");
        Console.WriteLine("2. Create Goal");
        Console.WriteLine("3. Save score and Achievements to File");
        Console.WriteLine("4. Load from File");
        Console.WriteLine("5. Quit");
        string selection = Console.ReadLine();
        if (selection == "1" || selection == "Player Info")
        {
            DisplayPlayerInfo();
        }
        else if (selection == "2" || selection == "Create Goal")
        {
            CreateGoal();
        }
        else if (selection == "3" || selection == "Save Score and Achievements to File")
        {
            
        }
        else if (selection == "4" || selection == "Load from file")
        {
            
        }

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"The player's score is {_score} points.");
        Console.WriteLine("Achievements: ");
        ListGoalDetails();
    }
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            string goalDetails = goal.GetDetailsString();
            string[] details = goalDetails.Split(",");
            Console.WriteLine(details[0]);
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            string details = goal.GetDetailsString();
            string[] strings = details.Split(";");
            if (strings.Length > 3)
            {
                string achievementName = strings[0];
                string achievementBody = strings[1];
                string numberAchieved = strings[2];
                string target = strings[3];
                Console.WriteLine($"{achievementName} - {achievementBody}");
                Console.Write($"Completion Status: {numberAchieved}/{target}  ");
                if (strings[4] == "true")
                {
                    string completionStatus = "Complete";
                    Console.WriteLine($"Completion Status: {completionStatus}");
                }
                else
                {
                    string completionStatus = "Not Complete";
                    Console.WriteLine($"Completion Status: {completionStatus}");
                }
                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();
                Start();
            }
            else
            {
                if (strings[2] == "True" || strings[2] == "False")
                {
                    string achievementName = strings[0];
                    string achievementBody = strings[1];
                    if (strings[2] == "True")
                    {
                        string completionStatus = "Complete";
                        Console.WriteLine($"{achievementName} - {achievementBody} - {completionStatus}");
                    }
                    else ()
                }
            }
        }
    }
    public void CreateGoal() // this function is for making new goals.
    {
        Console.WriteLine("Is the goal simple, a checklist, or an eternal goal?");
        string answer = Console.ReadLine();
        if (answer == "Simple")
        {
            Console.Write("What is the name of the new goal? ");
            string name = Console.ReadLine();
            Console.Write("What is the description of the new goal? ");
            string description = Console.ReadLine();
            int points = 50;
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (answer == "Checklist")
        {
            Console.Write("What is the name of the new goal? ");
            string name = Console.ReadLine();
            Console.Write("What is the description of the goal? ");
            string description = Console.ReadLine();
            int points = 10;
            Console.Write("How many times do you aim to achieve the goal? ");
            string achieveNumber = Console.ReadLine();
            int target = int.Parse(achieveNumber);
            int bonus = 150;
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
        else if (answer == "Eternal")
        {
            Console.Write("What is the name of the new goal? ");
            string name = Console.ReadLine();
            Console.Write("What is the description of the goal? ");
            string description = Console.ReadLine();
            int points = 50;
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
        }
    }
    public void RecordEvent()
    {
        Console.Write("Which goal would you like to update?");
        ListGoalNames();
    }
    public void SaveGoals()
    {
        string fileName = "lifeAchievements.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goals)
            {

            }
        }
    }
    public void LoadGoals()
    {

    }
}