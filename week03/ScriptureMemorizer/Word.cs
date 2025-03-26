using System;
using System.Globalization;

public class Word()
{
    public string _text;
    public int _numThis;
    public bool _isHidden;
    public Random _random = new Random();

    public void Word1(string text)  //why are we doing nothing to the text just injesting and vommitting the same thing.
    {
        _text = text;
    }
    public void Hide(string wordRandom, int randWordIndex)
    {
        _text = wordRandom;
        string blank = "";
        int textLength = _text.Length;
        int index = 0;
        while (index < textLength-1)
        {
            blank = blank + "_";
            index += 1;
        }
        _text = blank + "_";
    }
    
    public void Show() // Creates new string after randomly removed words have been replaced with underscores 
    {
        
    }
    public bool IsHidden(string theWord)
    {
        bool result;
        if (theWord[0] == '_')
        {
            result = false;
        }
        else
        {
            result = true;
        }
        return result;
    }
    public string GetDisplayText(string text)
    {
        _text = text;
        
        return _text;
    }
    
}