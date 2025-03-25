using System.Text.Json;


public class Scripture
{
    // Scripture is a list of verses
    public List<Verse> verses {get; set;} = new List<Verse>();

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
        aVerse.Book = book;

        Console.WriteLine("Enter the scripture content: ");
        string content = Console.ReadLine();
        aVerse.Content = content;

        Console.WriteLine("Enter the chapter: ");
        string chapter = Console.ReadLine();
        aVerse.Chapter = chapter;

        Console.WriteLine("Enter the chapter: ");
        string verse = Console.ReadLine();
        aVerse.Verse_number = verse;

        verses.Add(aVerse);
        Console.WriteLine($"Book: {aVerse.Book} {aVerse.Chapter}:{aVerse.Verse_number}");
        Console.WriteLine($"Scripture Text:\n{aVerse.Content}");
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
            string json3 = File.ReadAllText(file);
            verses = JsonSerializer.Deserialize<List<Verse>>(json3);
            Console.WriteLine("\n");
            foreach (var v in verses)
            {
                Console.WriteLine($"This is the reference: {v.Book} {v.Chapter} {v.Verse_number}");
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
            Console.WriteLine($"{v.Book} {v.Chapter}:{v.Verse_number}");
            Console.WriteLine($"{v.Content}");
        }
    }
    public void DisplayAll()
    {
        Console.WriteLine("\n");
        foreach (Verse v in verses)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"{v.Book} {v.Chapter}:{v.Verse_number}");
            Console.WriteLine($"{v.Content}");
        }
    }
    
}