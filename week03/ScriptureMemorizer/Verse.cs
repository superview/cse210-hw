using System;
using System.Net;

public class Verse
{
    public string _book;
    public string _chapter;
    public string _verse;
    public string _content;

    // Verse constructor
    public Verse()
    {

    }
    public string Book
    {
        get { return _book; }
        private set { _book = value; }
    }
    public string Chapter
    {
        get { return _chapter; }
        private set { _chapter = value; }
    } 
    public string verse
    {
        get { return _verse; }
        private set { _verse = value; }
    }
    public string Content
    {
        get { return _content; }
        private set { _content = value; }
    }
    // public void SetBook(string book)
    // {
    //     _book = book;

    // }
    // public void SetChapter(string chapter)
    // {
    //     _chapter = chapter;

    // }
    // public void SetVerse(string verse)
    // {
    //     _verse = verse;

    // }
    // public void SetContent(string content)
    // {
    //     _content = content;

    // }



}