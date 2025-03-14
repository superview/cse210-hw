using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        DateTime now = DateTime.Now;
        Entry e = new Entry();
        Journal j = new Journal();
        Prompt p = new Prompt();
        p.AddPrompt("ya baby yeah!");
        e._prompt = p.GetRandom();
        e._created = now;
        string random_prompt = p.GetRandom();
        Console.WriteLine($"This is a random quote: {random_prompt}");
        p.Display();
        // string _menu = ("1. Write"
        // 2. Display
        // 3. Load
        // 4. Save
        // 5. Quit")}
    }
}