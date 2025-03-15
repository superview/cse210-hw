using System;
using System.Dynamic;

// Entry class to get a prompt, present it to the user, and collect the entry from the user

public class Entry
{
    public string _name = "";
    public DateTime _created {get; set;}
    public string _prompt {get; set;}
    public string _entry {get; set;}

    // Entry constructor - Get a new prompt, display and get response.
    public Entry()
    {
        // Call for a new random quote
        DateTime theCurrentTime = DateTime.Now;
        _created = theCurrentTime;

    }

    public void Display()
    {
    }

}