using System;
using System.Collections.Generic;
using System.Net;
// using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Text.Json;

/// <summary>
/// Exceeding Requirements
// Write entries to a json file
// Automatically read entries from the json file upon startup
// Save the entry date in DateTime object for flexible and more accurate timestamping
/// </summary>
/// 

class Program
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        Entry e = new Entry();
        string file = "journal.json"; // save location
        Journal j = new Journal();
        Prompt p = new Prompt();
        p.AddPrompt("ya baby yeah!");
        e._prompt = p.GetRandom();
        e._created = now;
        string random_prompt = p.GetRandom();


        // Present menu and get action from user
        Boolean _loop = true;
        Console.WriteLine($"\nWelcome to your Journal!");
        while (_loop)
        {
            Console.WriteLine($"Please select from the following actions: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
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
                            Console.WriteLine("\n----- Entry --------------");
                            Console.WriteLine($"Date: {je._created.ToShortDateString()}    Prompt: {je._prompt}\nEntry:   {je._entry}");
                        }
                        break;
                    case 3:
                        // Load from json file
                        j.Load(file);
                        
                        break;
                    case 4:
                        // Save to json file
                            // file = "journal.json"; // save location

                        // either one of the following works to save the file
                        SaveToFile(j,file);
                        // j.Save(file);

                        break;
                    case 5:
                        Console.WriteLine("Exiting.");
                        _loop = false;
                        break;
                    default:
                        Console.WriteLine("Something went wrong. Please try again");
                        break;
                }
            };

        }

    }
    static void SaveToFile(Journal j, string file)
    {
        string jsonString = JsonSerializer.Serialize(j.entries, new JsonSerializerOptions {WriteIndented = true});
        File.WriteAllText(file, jsonString);
        Console.WriteLine(jsonString);
    }



}