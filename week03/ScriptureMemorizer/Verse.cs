using System;

public class Verse
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _content;
    
    
    // Verse constructor
    public Verse()
    {
    }


    public void AddWords()
    {
        Console.WriteLine("sometest");
        Console.WriteLine("heyt");
        Console.WriteLine("Enter the chapter: ");
        Word aword4 = new Word("stringthing");
        foreach (string w in _content.Split())
        {
            Console.WriteLine($"this is w: {w}");
        }
    }

    public string Book
    {
        get { return _book; }
        set { _book = value; }
    }
    public string Chapter
    {
        get { return _chapter; }
        set { _chapter = value; }
    } 
    public string Verse_number
    {
        get { return _verse; }
        set { _verse = value; }
    }
    public string Content
    {
        get { return _content; }
        set { _content = value; }
    }
}