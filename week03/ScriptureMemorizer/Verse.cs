using System;

public class Verse
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _content;
    // public List<Word> words { get; set; } = new List<Word>();
    
    
    // Verse constructor
    public Verse()
    {
    }


    public void AddWords()
    {
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
    public List<Word> words = new List<Word>();
}