using System;

public class PromptGenerator
{
    public List<string> _prompt = new List<string>();

    public string GetRandomPrompt(List<string> strings)
    {
        Random num = new Random();
        int index = num.Next(strings.Count);
        string prompt = strings[index];
        return prompt;
    }
}