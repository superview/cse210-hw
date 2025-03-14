using System;

// Entry class to get a prompt, present it to the user, and collect the entry from the user

public class Entry
{
    public string _name = "";
    public DateTime _created;
    public string _prompt = "";
    public string _entry = "";

    // Entry constructor - Get a new prompt, display and get response.
    public Entry()
    {
        // Call for a new random quote
        Console.WriteLine("in Entry");
        // _prompt = p.GetRandom();

    }

    public void Display()
    {
        Console.WriteLine("This is from the Entry class.");
    }

    

}