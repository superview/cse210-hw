public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    public Video()
    {
        Console.WriteLine("Constructor no action\n");
    }
    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _length = seconds;
    }
    public void Display(bool include_comments = true)
    {
        Console.WriteLine("\n====================================");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} minutes ({(float)_length/60.0:F2} hours)");
        Console.WriteLine($"Number of comments: {_comments.Count()}");
        // Console.WriteLine("\n************************************");
        foreach(Comment c in _comments)
        {
            c.Display();
        }
        Console.WriteLine("....................................\n");
    }
    public void AddComment(string author, string comment)
    {
        Comment c = new Comment(author, comment);
        _comments.Add(c);
    }

}