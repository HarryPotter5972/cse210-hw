using System;
using System.Xml.XPath;

public class Reference()
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    
    public void Reference1(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public void Reference2(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    public string GetReference()
    {
        if (_endVerse != 0)
        {
            string refer = $"{_book} {_chapter}:{_verse}-{_endVerse}";
            return refer;
        }
        else
        {
            string refer =  $"{_book} {_chapter}:{_verse}";
            return refer;
        }
    }
}