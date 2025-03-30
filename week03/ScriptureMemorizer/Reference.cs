using System;
using System.Runtime.CompilerServices;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference()
    {
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    public void SetReference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"In SetReference. Book: {_book} {_chapter}:{_verse}");
        Console.WriteLine("----------------------------------");
    }
    public string DisplayAll()
    {
        if( _endVerse > 0 )
        {
            return _book + " " + _chapter + ":" + _verse + "-" + _endVerse;
        }
        else
        {
            return _book + " " + _chapter + ":" + _verse;
        }
    }

}



