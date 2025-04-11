using System;

class Program
{
    static void Main(string[] args)
    {
        bool _loop = true;
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        while (_loop)
        {
            Console.WriteLine($"Please select from the following actions: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Mindfulnes Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            // Console.WriteLine("6. Test");
            Console.Write("Enter a number or the first character from the menu: ");

            ConsoleKeyInfo choice = Console.ReadKey(true);
            Console.Clear();

            // // Get user choice from command line menu
            switch (choice.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                case ConsoleKey.B:
                    // Hide another word if there are still words to hide
                    {
                        Console.WriteLine("\n+++ Breathing  +++++++++++++++++++");
                        break;
                    }

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                case ConsoleKey.M:
                    // Mindfulness

                    // foreach(Scripture s in _scripture_list)
                    // {
                        // s.DisplayAll();
                    // }
                    // break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                case ConsoleKey.L:
                    // Listing Activity.
                    ListingActivity _la = new();
                    // _la.ShowSpinner(10);
                    // _la.ShowCountDown(10);
                    _la.GetRandomPrompt();
                    Console.WriteLine("Enter a list item.");
                    string _input = Console.ReadLine();
                    Console.WriteLine($"You entered: {_input}");
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                case ConsoleKey.Q:
                    // Exit
                    Console.WriteLine("Exiting.");
                    _loop = false;
                    break;

                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                case ConsoleKey.T:
                    // Testing use only
                    Console.WriteLine("Testing.");
                    break;

                default:
                    Console.WriteLine("Something went wrong. Please try again");
                        break;
                }
        }
    }
}