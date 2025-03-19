using System;

class Program
{
    static void Main(string[] args)
    {
        bool _loop = true;
        Console.Clear();
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Scripture _scripture = new Scripture();
        string file = "scriptures.json";

        while (_loop)
        {
            Console.WriteLine($"Please select from the following actions: ");
            Console.WriteLine("1. Add a verse to the library");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Enter a number or the first character from the menu: ");

            ConsoleKeyInfo choice = Console.ReadKey(true);

            // // Get user choice from command line menu
            switch (choice.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                case ConsoleKey.A:
                    // Add a verse
                    _scripture.AddVerse();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                case ConsoleKey.D:
                    // Display all entries
                    _scripture.DisplayAll();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                case ConsoleKey.L:
                    // Load from json file
                    _scripture.Load(file);
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                case ConsoleKey.S:
                    // Save to json file
                    _scripture.Save(file);
                    break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                case ConsoleKey.Q:
                    Console.WriteLine("Exiting.");
                    _loop = false;
                    break;

                default:
                    Console.WriteLine("Something went wrong. Please try again");
                    break;
            }
        }

    }

}