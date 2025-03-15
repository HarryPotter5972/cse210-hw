using System.IO;

class Journal
{
    public List<Entry> _journalEntries = new List<Entry>();
    
    public void AddEntry(Entry newEntry)
    {
        PromptGenerator promptText = new PromptGenerator();
        string prompt1 = "What did you do today?";
        string prompt2 = "What are you planning to do tomorrow?";
        string prompt3 = "Did you do your scripture study today? If so, what did you study?";
        string prompt4 = "Did you do your course work today? If so, for what class?";
        string prompt5 = "Did you play video games today? If so, did you play on console or PC and which game or games did you play?";
        promptText._prompt.Add(prompt1);
        promptText._prompt.Add(prompt2);
        promptText._prompt.Add(prompt3);
        promptText._prompt.Add(prompt4);
        promptText._prompt.Add(prompt5);
        DateTime today = DateTime.Now;
        newEntry._date = today.ToShortDateString();           
        newEntry._promptText = promptText.GetRandomPrompt(promptText._prompt);
        Console.WriteLine(newEntry._promptText);
        newEntry._entryText = Console.ReadLine();


    }

    public void DisplayAll(List<Entry> Diary)
    {
        foreach (Entry entry in Diary)
        {
            entry.Display(entry._date, entry._promptText, entry._entryText);
        }
    }

    public void SaveToFIle(string file, List<Entry> Diary)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in Diary)
            {
                outputFile.WriteLine(value: $"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }
    
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Entry oldEntry = new Entry();
            _journalEntries.Add(oldEntry);
            string[] parts = line.Split(",");
            oldEntry._date = parts[0];
            oldEntry._promptText = parts[1];
            oldEntry._entryText = parts[2];
        }
    }


}