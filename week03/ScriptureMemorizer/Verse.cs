using System;
using System.Net;

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