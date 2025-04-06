using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to the YouTubeVideos Project.");
        Video v1 = new Video("Mr. Magoo", "Manny Wallace",131);
        v1.AddComment("The Author", "This is the comment 1");
        v1.AddComment("Another Author", "Sometimes you just gotta go for the popcorn.");
        v1.AddComment("Brent Wood", "This was a long video.");

        Video v2 = new Video("How to sharpen a pencil.", "Nancy Fastio",10);
        v2.AddComment("Jason Argo", "Sometimes you just need to start with a sharp pencil.");
        v2.AddComment("Mary Lamb", "Sometimes you just gotta go for the popcorn.");
        v2.AddComment("Marsha Carrigan", "I have watched several of these videos and I just can't stop.");

        Video v3 = new Video("What is this?", "Sender.remember",4);
        v3.AddComment("Ramo.87", "This was a short video but still not worth the time.");
        v3.AddComment("Author.again", "Sometimes you just have to say no.");
        v3.AddComment("Silly.Putty", "I really liked this video. I'm looking for more where this came from.");
        
        v1.Display();
        v2.Display();
        v3.Display();

    }

}
