using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to the YouTubeVideos Project.");
        Video v = new Video("Mr. Magoo", "Manny Wallace",131);
        v.AddComment("The Author", "This is the comment 1");
        v.AddComment("Another Author", "Sometimes you just gotta go for the popcorn.");
        v.Display();

    }

}
