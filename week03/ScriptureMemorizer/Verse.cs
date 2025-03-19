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
    }
    public string Chapter
    {
        get { return _chapter; }
    }
    public string GetVerse()
    {
        return _verse;
    }
    public string GetContent()
    {
        return _content;
    }
    public void SetBook(string book)
    {
        _book = book;

    }
    public void SetChapter(string chapter)
    {
        _chapter = chapter;

    }
    public void SetVerse(string verse)
    {
        _verse = verse;

    }
    public void SetContent(string content)
    {
        _content = content;

    }



}