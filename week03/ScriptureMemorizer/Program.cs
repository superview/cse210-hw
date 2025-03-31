using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        bool _loop = true;
        Console.Clear();
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        
        // create list of scriptures
        List<Scripture> _scripture_list = new List<Scripture> ();
        // create first scripture
        string scripture_input1 = "And men are instructed sufficiently that they know good from evil. And the law is given unto men. And by the law no flesh is justified; or, by the law men are cut off. Yea, by the temporal law they were cut off; and also, by the spiritual law they perish from that which is good, and become miserable forever.";
        Scripture _scripture = new Scripture(new Reference( "2 Nephi",  2, 5), scripture_input1);
        _scripture_list.Add(_scripture);

        // add with inline content
        _scripture_list.Add(new Scripture(new Reference("Kings",12,15,23), "some sort of text"));
        
        // string file = "scriptures.json";

        while (_loop)
        {
            Console.WriteLine($"Please select from the following actions: ");
            Console.WriteLine("1. Add a verse to the library");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Test");
            Console.Write("Enter a number or the first character from the menu: ");

            ConsoleKeyInfo choice = Console.ReadKey(true);

            // // Get user choice from command line menu
            switch (choice.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                case ConsoleKey.A:
                    // Add a verse
                    // _scripture.AddVerse();
                    Console.WriteLine("NOT IMPLEMENTED");
                    _scripture.HideRandomWords(3);
                    

                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                case ConsoleKey.D:
                    // Display all entries
                    foreach(Scripture s in _scripture_list)
                    {
                        s.DisplayAll();
                    }
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                case ConsoleKey.L:
                    // Load from json file
                    // _scripture.Load(file);
                    Console.WriteLine("NOT IMPLEMENTED");
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                case ConsoleKey.S:
                    // Save to json file
                    // _scripture.Save(file);
                    Console.WriteLine("NOT IMPLEMENTED");
                    break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                case ConsoleKey.Q:
                    Console.WriteLine("Exiting.");
                    _loop = false;
                    break;

                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                case ConsoleKey.T:
                    Console.WriteLine("Testing.");
                    Word aword = new Word("this_is_a_word");
                    Console.WriteLine(aword.GetDisplayText());
                    aword.Hide();
                    Console.WriteLine(aword.GetDisplayText());

                    break;

                default:
                    Console.WriteLine("Something went wrong. Please try again");
                    break;
            }
        }

    }

}