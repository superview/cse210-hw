using System.Runtime.CompilerServices;
using System.Text.Json;

public class Scripture
{
    private Reference _reference { get; set; } = new("boooook",3,24);
    private List<Word> Words { get; set; } = new List<Word>();
    public Scripture(Reference _reference, string text)
    {
        // string file = "scriptures.json";
        
        //    _reference = ((string)"Book 1", (int) 2, (int) 22);
        string scripture_input1 = "And men are instructed sufficiently that they know good from evil. And the law is given unto men. And by the law no flesh is justified; or, by the law men are cut off. Yea, by the temporal law they were cut off; and also, by the spiritual law they perish from that which is good, and become miserable forever.";
        foreach(string w in scripture_input1.Split())
        {
            Words.Add(new Word(w, true));
        }
        // Load(file);
    }

    public void setReference(string book, int chapter, int verse)
    {
        // _reference = (book, chapter, verse)

    }
    public void HideRandomWords(int numberToHide)
    {
        // 

    }

    public string GetDisplayText()
    {
        return "string";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }

    // add a verse to a scripture
    // public Verse AddVerse()
    // {
    //     Verse aVerse = new();

    //     Console.WriteLine("Enter the book: ");
    //     string book = Console.ReadLine();
    //     aVerse.Book = book;

    //     Console.WriteLine("Enter the scripture content: ");
    //     string content = Console.ReadLine();
    //     aVerse.Content = content;

    //     Console.WriteLine("Enter the chapter: ");
    //     string chapter = Console.ReadLine();
    //     aVerse.Chapter = chapter;

    //     Console.WriteLine("Enter the chapter: ");
    //     string verse = Console.ReadLine();
    //     aVerse.Verse_number = verse;

    //     verses.Add(aVerse);
    //     Console.WriteLine($"Book: {aVerse.Book} {aVerse.Chapter}:{aVerse.Verse_number}");
    //     Console.WriteLine($"Scripture Text:\n{aVerse.Content}");
    //     return aVerse;
    // }
    // public void Save(string file)
    // {
    //     string jsonString = JsonSerializer.Serialize(verses, new JsonSerializerOptions {WriteIndented = true});
    //     File.WriteAllText(file, jsonString);
    //     Console.WriteLine(jsonString);
    //     Console.WriteLine("Saved to file: " + file);
    // }
    // public void Load(string file)
    // {
    //     try
    //     {
    //         string json3 = File.ReadAllText(file);
    //         verses = JsonSerializer.Deserialize<List<Verse>>(json3);
    //         Console.WriteLine("\n");
    //         foreach (var v in verses)
    //         {
    //             Console.WriteLine($"This is the reference: {v.Book} {v.Chapter} {v.Verse_number}");
    //         }
    //         // Success loading file
    //         Console.WriteLine($"{file} loaded.");
    //     }
    //     catch (IOException ex)
    //     {
    //         Console.WriteLine($"Initial load of scriptures could not be completed. {ex.Message}");
    //     }
    // }
    public int GetRandomScripture()
    {
        Random rand = new Random();
        int selected = rand.Next(1, Words.Count);
        return selected;
    }

    public void DisplayAll()
    {
        Console.WriteLine("\n");
        Console.WriteLine($"Reference: {_reference.DisplayAll()}");
        foreach (Word w in Words)
        {
            // Console.WriteLine($"{w.GetDisplayText} {w.Chapter}:{w.Verse_number}");
            Console.Write($"{w.GetDisplayText()} ");
        }
        // Write line after quote
        Console.WriteLine("\n");
    }
    
}