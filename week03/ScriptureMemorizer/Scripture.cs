using System;

class Scripture()
{
    public Reference _reference = new Reference();
    public List<Word> _words = new List<Word>();
    public void Scripture1(Reference reference, string text)
    {
        Console.WriteLine($"{reference} {text}");
    }
    public void HideRandomWords(int numberToHide)
    {
        int numberHidden = 0;
        while (numberHidden < numberToHide)
        {
            foreach (Word word in _words)
            {
                int randNumber = word._random.Next(0,1);
                bool result = word.IsHidden(randNumber);
                if (result == true)
                {
                    word.Hide();
                    numberHidden =+ 1;
                }
            }
        }
        
    }
    public void GetDisplayText(int wordsLength)
    {
        int index = 0;
        while (index < wordsLength-1)
        {
            string word =_words.show(wordslength)
        }
        Console.WriteLine($"{_words[index]._text}");
    }
    public bool IsCompletelyHidden(int number)
    {
        bool allHidden;
        if (number == 0)
        {
            allHidden = false;
        }
        else
        {
            allHidden = true;
        }
        return allHidden;
    }
}