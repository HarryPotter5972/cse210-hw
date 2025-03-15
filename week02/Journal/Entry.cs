using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display(string date, string prompt, string textEntry)
    {
        Console.WriteLine($"Date: {date} - Prompt: {prompt}");
        Console.WriteLine($"{textEntry}");
    }
}