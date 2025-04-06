using System;
using System.Diagnostics.CodeAnalysis;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions;

    public void ActivityReflecting()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(30);
        Run();
    }
    private void Run()
    {
        
        Console.WriteLine("Consider the following prompt: ");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to enter.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions on how they are connected to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        DisplayQuestions();
    }
    private string GetRandomPrompt()
    {
        _prompts.Add("");
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }
    private string GetRandomQuestion()
    {
        _questions.Add("");
        Random random = new Random();
        int index = random.Next(0, _questions.Count);
        string question = _questions[index];
        return question;
    }
    private void DisplayPrompt()
    {
        _prompts.Add("Think of a time when you did something really hard.");
        _prompts.Add("Think of a time where you were in the wilderness");
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }
    private void DisplayQuestions()
    {
        Console.Clear();
        _questions.Add("How did you feel when it was done? ");
        _questions.Add("What was your favorite part of the experience> ");
        _questions.Add("");
        while (DateTime.Now < DateTime.Now.AddSeconds(_duration))
        {
            string question = GetRandomQuestion();
            Console.Write(question);
            ShowSpinner(10);
            Console.WriteLine();
        }
    }

}