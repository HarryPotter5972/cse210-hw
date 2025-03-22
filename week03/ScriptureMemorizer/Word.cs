using System;
using System.Globalization;

public class Word()
{
    public string _text;
    private bool _isHidden = new bool();
    public Random _random = new Random();

    public string Word1(string text)  //why are we doing nothing to the text just injesting and vommitting the same thing.
    {
        _text = text;
        return _text;
    }
    public void Hide()
    {
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
    
    public void Show(int wordslength, int index) // Creates new string after randomly removed words have been replaced with underscores 
    {
    ;
    }
    public bool IsHidden(int number)
    {
        bool _isHidden;
        if (number == 0)
        {
            _isHidden = false;
        }
        else
        {
            _isHidden = true;
        }
        return _isHidden;
    }
    public string GetDisplayText(string text)
    {
        
        
        return "";
    }
}