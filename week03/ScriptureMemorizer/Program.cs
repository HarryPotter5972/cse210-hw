using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        List<string> ScriptAndIndex = scripture.ScriptureChoose();
        string scriptureWhole = ScriptAndIndex[0];
        Console.WriteLine(ScriptAndIndex[0]);
        scripture.SectionSeparate(scriptureWhole);
        int length = scripture.GetScriptLength();
        Console.WriteLine("Press the enter key or type 'quit' to finish:");
        string entry =Console.ReadLine();
        int numHidden = 0;
        bool allIsHidden = false;
        while (entry != "quit" || allIsHidden == false)
        {
            Console.Clear();
            Random random = new Random();
            int numberToHide = random.Next(1, 3);
            int incNumber = 0;
            bool everythingHidden = false; //scripture.IsCompletelyHidden(numberToHide);
            int randNumber = random.Next(0,2); //in privides random number 
            int randWordIndex = random.Next(0,length);
            while (everythingHidden == false)
            {
                Console.WriteLine(randWordIndex);  //delete leater
                Console.WriteLine("This was the Randomn Word Index.");
                string wordRandom = scripture._words[randWordIndex]._text;
                Console.WriteLine("I got to HideRandomWords Yay!!!");
                scripture.HideRandomWords(numberToHide, randNumber, wordRandom, randWordIndex);
                everythingHidden = scripture.IsCompletelyHidden(incNumber);
                randWordIndex = random.Next(0, length);
                incNumber =+ 1;
            }
            Console.Write($"{scripture._reference.GetReference()} - ");
            scripture.GetDisplayText(length);
            numHidden =+ numberToHide;
            allIsHidden = scripture.AllIsHidden(numHidden, length);
            Console.WriteLine("Presss the enter key or type 'quit' to finish:");
            entry = Console.ReadLine();

        }
        

        

    }
}