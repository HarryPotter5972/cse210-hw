using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        string scriptureWhole = "Luke 2:1-7 - And it came to pass in those days, that there went out a decree from Caesar Augustus, that all the world should be taxed. (And this taxing was first made when Cyrenius was governer of Syria.) And all went to be taxed, every one into his own city. And Joseph also went up from Galilee, out of the city of Nazareth, unto the city of David, which is called Bethlehem; (because he was of the house and lineage of David:) To be taxed with Mary his espoused wife, being great with child.";
        Console.WriteLine(scriptureWhole);
        Scripture scripture = new Scripture();
        string[] parts = scriptureWhole.Split(" - ");
        string reference = parts[0];
        string scriptureText = parts[1];
        string[] scriptureWords = scriptureText.Split(" ");
        Console.WriteLine(scriptureWords);
        int index = 0;
        int scriptureWordsLength = scriptureWords.Length;
        while (index < scriptureWordsLength)
        {
            Word word = new Word();
            word._text = scriptureWords[index];
            scripture._words.Add(word);
            index +=1;
        }
        string[] referenceParts = reference.Split(" ");
        string book = referenceParts[0];
        string chapterVerse = referenceParts[1];
        string[] chaperVerseSplit = chapterVerse.Split(":");
        int chapter = int.Parse(chaperVerseSplit[0]);
        string verse = chaperVerseSplit[1];
        int verseLength = verse.Length;
        if (verseLength > 2)
        {
            string[] verseSplit = verse.Split("-");
            int startVerse = int.Parse(verseSplit[0]);
            int endVerse = int.Parse(verseSplit[1]);
            scripture._reference.Reference2(book, chapter, startVerse, endVerse);
        }
        else
        {
            int verse1 = int.Parse(verse);
            scripture._reference.Reference1(book, chapter, verse1);
        }
        Console.WriteLine("Press the enter key or type 'quit' to finish:");
        string entry =Console.ReadLine();
        while (entry != "quit")
        {
            Console.Clear();
            Random random = new Random();
            int numberToHide = random.Next(1,2);
            int number = 0;
            bool everythingHidden = scripture.IsCompletelyHidden(number);
            while (everythingHidden == false)
            {
                scripture.HideRandomWords(numberToHide);
                number =+ 1;
                everythingHidden = scripture.IsCompletelyHidden(number);
            }
            
            scripture.GetDisplayText(verseLength);
            Console.WriteLine("Presss the enter key or type 'quit' to finish:");
            entry = Console.ReadLine();

        }

        

    }
}