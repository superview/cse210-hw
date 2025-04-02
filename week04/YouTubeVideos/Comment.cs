public class Comment
{
    private string _text;
    private string _author;

    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }
    public void Display()
    {
        Console.WriteLine("====================================");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Comment: {_text}");
    }

}