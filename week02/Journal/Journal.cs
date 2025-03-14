using System;

public class Journal
{
    public List<Entry> entries = new List<Entry>();
    // Journal constructor
    public Journal()
    {
        Console.WriteLine("Journal constructor.");
    }
    // a collection of entries
    public Entry AddEntry()
    {
        // Add an Entry to the Journal.
        // Console.WriteLine("Add Entry:");
        Prompt a_prompt = new ();
        Entry en1 = new Entry();
        en1._prompt = a_prompt.GetRandom();
        Console.WriteLine(en1._prompt);
        string response = Console.ReadLine();
        en1._entry = response;
        entries.Add(en1);

        // print out en1
        Console.WriteLine("Printing out the contents of Entry en1:");
        Console.WriteLine($"prompt: {en1._prompt}\nentry: {en1._entry}");

        return en1;


    }
    public void DisplayAll()
    {

    }
    public void Save(string file)
    {

    }

    public void Load(string file)
    {

    }

}