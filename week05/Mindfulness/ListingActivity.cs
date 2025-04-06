using System;

public class ListingActivity : Activity
{
    public int _count;

    private List<string> _prompts = new List<string>();


    public void ListActivity()
    {
        
         Console.Write("Get ready...");
        ShowSpinner(5);
        Run();
    }
    private void Run()
    {
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        List<string> entries = GetListFromUser();
        Console.Write($"You listed {_count} items. The items are: ");
        foreach (string entry in entries)
        {
            Console.WriteLine($"{entry}");
        }
    }
    private void GetRandomPrompt()
    {
        _prompts.Add("List your favorite Pokemon.");
        _prompts.Add("List your favorite Yu-gi-oh! cards.");
        _prompts.Add("List your favorite movies");
        Random random = new Random();
        int index = random.Next(0, 2);
        Console.WriteLine(_prompts[index]);
    }
    protected List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        while (DateTime.Now < startTime.AddSeconds(_duration))
        {
            Console.ReadLine();
            _count +=1;
        }
        return items;
    }
}