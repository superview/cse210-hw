using System;
using System.Text.Json;


public class Scripture
{
    // Scripture is a list of verses
    public List<Verse> verses {get; set;} = new List<Verse>();
    string file = "scriptures.json";

    public Scripture()
    {
        string file = "scriptures.json";
        Load(file);
    }

    // add a verse to a scripture
    public Verse AddVerse()
    {
        Verse aVerse = new Verse();

        Console.WriteLine("Enter the book: ");
        string book = Console.ReadLine();
        aVerse.SetBook(book);

        Console.WriteLine("Enter the scripture content: ");
        string content = Console.ReadLine();
        aVerse.SetContent(content);

        Console.WriteLine("Enter the chapter: ");
        string chapter = Console.ReadLine();
        aVerse.SetChapter(chapter);

        Console.WriteLine("Enter the chapter: ");
        string verse = Console.ReadLine();
        aVerse.SetVerse(verse);

        verses.Add(aVerse);
        Console.WriteLine($"Book: {aVerse.Book} {aVerse.Chapter}:{aVerse.GetVerse()}");
        Console.WriteLine($"Scripture Text:\n{aVerse.GetContent()}");
        return aVerse;
    }
    public void Save(string file)
    {
        string jsonString = JsonSerializer.Serialize(verses, new JsonSerializerOptions {WriteIndented = true});
        File.WriteAllText(file, jsonString);
        Console.WriteLine(jsonString);
        Console.WriteLine("Saved to file: " + file);

    }
    public void Load(string file)
    {
        try
        {
            using (StreamReader reader = new StreamReader(file))
            {
                verses = JsonSerializer.Deserialize<List<Verse>>(reader.ReadToEnd());
            }
            // Success loading file
            Console.WriteLine($"{file} loaded.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Initial load of scriptures could not be completed. {ex.Message}");
        }
    }
    public int GetRandomScripture()
    {
        Random rand = new Random();
        int selected = rand.Next(1, verses.Count);
        return selected;
    }
    public void DisplayR()
    {
        foreach (Verse v in verses)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"{v.Book} {v.Chapter}:{v.GetVerse()}");
            Console.WriteLine($"{v.GetContent()}");
        }
    }
    public void DisplayAll()
    {
        foreach (Verse v in verses)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"{v.Book} {v.Chapter}:{v.GetVerse()}");
            Console.WriteLine($"{v.GetContent()}");
            string aaa = v.Book;
            Console.WriteLine($"The aaa is: {aaa}");
        }
    }
    
}