using System;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
// using System.Runtime.InteropServices.Marshalling;
// using System.Dynamic;

public class Journal
{
    // public List<Entry> entries = new List<Entry>();
    public List<Entry> entries {get; set;} = new List<Entry>();
    public List<Entry> entries2 = new List<Entry>();
    // Journal constructor
    public Journal()
    {
        string file = "journal.json"; // save location
        Load(file);
    }
    // a collection of entries
    public Entry AddEntry()
    {
        // Add an Entry to the Journal.
        // Console.WriteLine("Add Entry:");
        Prompt a_prompt = new();
        Entry en1 = new Entry();
        en1._prompt = a_prompt.GetRandom();
        Console.WriteLine($"Date: {en1._created.ToShortDateString()}  Prompt: {en1._prompt}");
        string response = Console.ReadLine();
        en1._entry = response;
        entries.Add(en1);
        // return the new object
        return en1;
    }
    public void DisplayAll()
    {
    }
    public void Save(string file)
    {
        string jsonString = JsonSerializer.Serialize(entries, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(file, jsonString);
        Console.WriteLine(jsonString);
        Console.WriteLine("Saved to file: " + file);
    }


    public void Load(string file)
    {
        string jsonString = File.ReadAllText(file);
        entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
        Console.WriteLine($"{file} loaded.");
    }
}
