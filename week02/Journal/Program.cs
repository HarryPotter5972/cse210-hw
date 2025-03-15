using System;
using System.Collections.Specialized;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        Journal JournalEntry = new Journal();
        Console.WriteLine("Welcome to the Journal.");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do?");
        string reply = Console.ReadLine();
        if (reply == "5" || reply == "Quit")
        {
            Console.WriteLine("See you next time!");
        }
        else
        {
            while (reply != "6" || reply != "Very Quit")
            {
                if (reply == "1" || reply == "Write")
                {
                    
                    Entry newEntry = new Entry();
                    JournalEntry.AddEntry(newEntry);
                    JournalEntry._journalEntries.Add(newEntry);
                    Console.Write("Do you want to do more? ");
                    reply = Console.ReadLine();
                }
                else if (reply == "2" || reply == "Display")
                {
                    JournalEntry.DisplayAll(JournalEntry._journalEntries);
                    Console.WriteLine("Want to do more?");
                    reply = Console.ReadLine();
                }
                else if (reply == "3" || reply == "Load")
                {
                    Console.Write("What file to you want to load? ");
                    string fileName = Console.ReadLine();
                    JournalEntry.LoadFromFile(fileName);
                    Console.Write("Want to do more? ");
                    reply = Console.ReadLine();
                }
                else if (reply == "4" || reply == "Save")
                {
                    Console.Write("What file name do you want to save the journal to? ");
                    string fileName = Console.ReadLine();
                    JournalEntry.SaveToFIle(fileName, JournalEntry._journalEntries);
                    Console.WriteLine("Want to do more?");
                    reply = Console.ReadLine();
                }
                else if (reply == "5" || reply == "Quit")
                {
                    Console.WriteLine("See you next time!");
                    break;
                }                      
            }
        }
        
    }
}