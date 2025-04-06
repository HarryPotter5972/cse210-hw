using System;
using System.Security.Cryptography.X509Certificates;

public class Scripture()
{
    private List<string> _scriptures = new List<string>();
    
    private int _scriptureWordsLength; 

    private void ScriptureAdd() // for adding scriptures to list _scriptures for random sellection.
    {
        _scriptures.Add("Luke 2:1-7 - And it came to pass in those days, that there went out a decree from Caesar Augustus, that all the world should be taxed. (And this taxing was first made when Cyrenius was governer of Syria.) And all went to be taxed, every one into his own city. And Joseph also went up from Galilee, out of the city of Nazareth, unto the city of David, which is called Bethlehem; (because he was of the house and lineage of David:) To be taxed with Mary his espoused wife, being great with child.");
        _scriptures.Add("Luke 2:8-14 - And there in the same country shepherds abiding in the field, keeping wath over their flock by night. And, lo, the angel of the Lord came upon them, and the glory of the Lord shone around about them: and they were sore afraid. And the angel said unto them, Fear not: for behold, I bring you tidings of great joy, which shall be to all people. For unto you is born this day in the city of David a Savior, which is Christ the Lord. And this shall be a sign unto you; Ye shall find the babe wrapped in swaddling clothes, lying in a manger. And suddenly there was with the angel a multitude of the heavenly host praising God, and saying, Glory to God in the highest, and on earth peace, good will toward men.");
        _scriptures.Add("Luke 2:15 - And it came to pass, as the angels were gone away from them into heaven, the shepherds said one to another, Let us go even unto Bethlehem, and see this thing which come to pass, which the Lord hath made known unto us.");
        _scriptures.Add("Luke 2:16-17 - And they came with haste, and found Mary, and Joseph, and the babe lying in a manger. And when they had seen it, they made known abroad the saying which was told them concerning this child.");
    }
    public List<string> ScriptureChoose() // For choosing a random scripture from _scriptures and puts it into main program for memorisation.
    {
        ScriptureAdd();
        Random scriptureSelect = new Random();
        List<string> chosScritAndIndex = new List<string>();
        int chosenScriptureIndex = scriptureSelect.Next(0,4);
        string chosenScripture = _scriptures[chosenScriptureIndex];
        string cSI = chosenScriptureIndex.ToString();
        chosScritAndIndex.Add(chosenScripture);
        chosScritAndIndex.Add(cSI);
        return chosScritAndIndex;
    }
    public Reference _reference = new Reference();
    public List<Word> _words = new List<Word>();

    public void SectionSeparate(string scriptureEntry) //For splitting the scripture up into different parts.
    {
        string[] parts = scriptureEntry.Split(" - ");
        string reference = parts[0];
        string scriptureText = parts[1];
        string[] scriptureWords = scriptureText.Split(" ");
        Console.WriteLine(scriptureWords);
        int index = 0;
        _scriptureWordsLength = scriptureWords.Length;

        while (index < _scriptureWordsLength)
        {
            Word word = new Word();
            word.Word1(scriptureWords[index]);
            _words.Add(word);
            index +=1;
        }
        string[] referenceParts = reference.Split(" ");
        string book = referenceParts[0];
        string chapterVerse = referenceParts[1];
        string[] chaperVerseSplit = chapterVerse.Split(":");
        int chapter = int.Parse(chaperVerseSplit[0]);
        string verse = chaperVerseSplit[1];
        int verseLength = verse.Length;
        Console.WriteLine("This is the length of the verse");   //Delete me
        Console.WriteLine(_scriptureWordsLength);
        if (verseLength > 2)
        {
            string[] verseSplit = verse.Split("-");
            int startVerse = int.Parse(verseSplit[0]);
            int endVerse = int.Parse(verseSplit[1]);
            _reference.Reference2(book, chapter, startVerse, endVerse);
        }
        else
        {
            int verse1 = int.Parse(verse);
            _reference.Reference1(book, chapter, verse1);
        }
    }
    private int GetLength()
    {
        int length = _scriptureWordsLength;
        return length;
    }

     public int GetScriptLength()
    {
        int scLength = GetLength();
        return scLength;
    }
    public void Scripture1(Reference reference, string text)
    {
        Console.WriteLine($"{reference} - {text}");
    }
    public void HideRandomWords(int numberToHide, int randNumber, string wordRandom, int randWordIndex)
    {
        Word word = _words[randWordIndex];
        int numberHidden = 0;
        Console.WriteLine(randNumber);  //delete me later
        bool resultb = word.IsHidden(wordRandom);
        Console.WriteLine(numberHidden);
        Console.WriteLine("This is the result of IsHidden");  //delete me later
        Console.WriteLine(resultb);  //delete me later
        if (resultb == true)
        {
            word.Hide(wordRandom, randWordIndex);
            numberHidden =+ 1;
        }
        else
        {
            Console.WriteLine("Nothing Here");  //delete me later
            numberHidden =+ 1;
        }
        
    }
    public void GetDisplayText(int wordsLength)
    {
        int index = 0;
        while (index < wordsLength-1)
        {
            Console.Write($"{_words[index]._text} ");

            index += 1;
        }
        Console.WriteLine($"{_words[index]._text}");
    }
    public bool IsCompletelyHidden(int hidnNumber)
    {
        Console.WriteLine("IsCompletelyHidenOutput");
        Console.WriteLine(hidnNumber);  //delete me later
        bool allHidden;
        if (hidnNumber == 0)
        {
            allHidden = false;
        }
        else
        {
            allHidden = true;
        }
        Console.WriteLine("New All Hidden Info");
        Console.WriteLine(allHidden);  //delete me later
        return allHidden;
    }
    public bool AllIsHidden(int numHidden, int length)
    {
        bool allIsHidden;
        if (numHidden < length)
        {
            allIsHidden = true;
        }
        else
        {
            allIsHidden = false;
        }
        return allIsHidden;
    }
}