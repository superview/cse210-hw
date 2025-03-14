using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
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


        // Present menu and get action from user
        Boolean _loop = true;
        while (_loop)
        {
            Console.WriteLine($"Welcome to your Journal!\nPlease select from the following actions: ");
            // Console.WriteLine("1. Write");
            // Console.WriteLine("2. Display");
            // Console.WriteLine("3. Load");
            // Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Enter a number: ");
            string input = "";

            // Get user choice from cl menu
            input = Console.ReadLine();
            if (int.TryParse((string)input, out int choice))
            {
                Console.WriteLine("\nYou entered: " + choice);
                switch (choice)
                {
                    case 1:
                        // Write new entry
                        j.AddEntry();

                        break;
                    case 2:
                        // Display all entries
                        foreach (Entry je in j.entries)
                        {
                            Console.WriteLine("----- Entry --------------");
                            Console.WriteLine($"  Prompt: {je._prompt}\nEntry:   {je._entry}");
                        }
                        break;
                    case 3:
                        // Load from json file
                        Console.WriteLine("selected 3");
                        break;
                    case 4:
                        // Save to json file
                        Console.WriteLine("selected 4");
                        break;
                    case 5:
                        Console.WriteLine("selected 5");
                        _loop = false;
                        break;
                    default:
                        Console.WriteLine("Something went wrong. Please try again");
                        break;
                }
            };

        }

    }


    // j.AddEntry();

    // p.Display();
    // string _menu = ("1. Write"
    // 2. Display
    // 3. Load
    // 4. Save
    // 5. Quit")}
}