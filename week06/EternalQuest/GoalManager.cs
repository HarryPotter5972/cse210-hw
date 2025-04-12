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
        Console.WriteLine("3. Save scores to a file");
        Console.WriteLine("4. Load from File");
        Console.WriteLine("5. Quit");
        string selection = Console.ReadLine();
        while (selection != "7" || selection != "quit")
        {
            if (selection == "1" || selection == "Player Info")
            {
                DisplayPlayerInfo();
            }
            else if (selection == "2" || selection == "List goals")
            {
                ListGoalNames();
            }
            else if (selection == "3" || selection == "List Goal Details")
            {

            }
            else if (selection == "4" || selection == "Create Goal")
            {

            }
        }

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"The player's score is {_score} points.");
        foreach (Goal goal in _goals)
        {

        }
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

    }
    public void CreateGoal() // this function is for making new goals.
    {
        Console.WriteLine("Is the goal simple, a checklist, or an eternal goal?");
        string answer = Console.ReadLine();
        if (answer == "Simple")
        {
            string name = Console.ReadLine();
            string description = Console.ReadLine();
            int points = 0;
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (answer == "Checklist")
        {
            Console.Write("What is the name of the new goal? ");
            string name = Console.ReadLine();
            Console.Write("What is the description of the goal? ");
            string description = Console.ReadLine();
            int points = 0;
            Console.Write("How many times do you aim to achieve the goal? ");
            string achieveNumber = Console.ReadLine();
            int target = int.Parse(achieveNumber);
            int bonus = 150;
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
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