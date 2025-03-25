using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


public class Scripture
{
    // Scripture is a list of verses
    public List<Verse> _verses {get; set;} = new List<Verse>();

    public Scripture()
    {
        string file = "scriptures.json";
        Load(file);
    }

    // add a verse to a scripture
    public Verse AddVerse()
    {
        Verse aVerse = new Verse();

        // Console.WriteLine("Enter the book: ");
        // string book = Console.ReadLine();
        // aVerse.SetBook(book);

        // Console.WriteLine("Enter the scripture content: ");
        // string content = Console.ReadLine();
        // aVerse.Content = content;

        // Console.WriteLine("Enter the chapter: ");
        // string chapter = Console.ReadLine();
        // aVerse.Chapter = chapter;

        // Console.WriteLine("Enter the chapter: ");
        // string verse = Console.ReadLine();
        // aVerse.verse = verse;

        // verses.Add(aVerse);
        Console.WriteLine($"Book: {aVerse.Book} {aVerse.Chapter}:{aVerse.verse}");
        Console.WriteLine($"Scripture Text:\n{aVerse.Content}");
        return aVerse;
    }
    public void Save(string file)
    {
        string jsonString = JsonSerializer.Serialize(_verses, new JsonSerializerOptions {WriteIndented = true});
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
                _verses = JsonSerializer.Deserialize<List<Verse>>(reader.ReadToEnd());
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
        int selected = rand.Next(1, _verses.Count);
        return selected;
    }
    public void DisplayR()
    {
        foreach (Verse v in _verses)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"{v.Book} {v.Chapter}:{v.verse}");
            Console.WriteLine($"{v.Content}");
        }
    }
    public void DisplayAll()
    {
        foreach (Verse v in _verses)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"{v.Book} {v.Chapter}:{v.verse}");
            Console.WriteLine($"{v.Content}");
            string aaa = v.Book;
            Console.WriteLine($"The aaa is: {aaa}");
        }
    }
    
}