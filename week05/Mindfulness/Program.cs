using System;
using System.ComponentModel;

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
                    Console.WriteLine("\n+++ Breathing  +++++++++++++++++++");
                    Console.WriteLine("Do you want a (s)pinner or a (c)ount down timer?");
                    string c_style = "count_down";
                    ConsoleKeyInfo style = Console.ReadKey(true);
                    switch (style.Key)
                    {
                        case ConsoleKey.S:
                        c_style = "spinner";
                        break;
                    }

                    BreathingActivity am = new BreathingActivity("Breating","Breath in, hold, and breath out for the count of 4 and repeat until the timer stops.",c_style);
                    am.SetDuration(am.InitializeTimer());
                    am.Run();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                case ConsoleKey.M:
                    // Mindfulness
                    // InitializeTimer();
                    Console.WriteLine("Do you want a (s)pinner or a (c)ount down timer?");
                    c_style = "count_down";
                    style = Console.ReadKey(true);
                    switch (style.Key)
                    {
                        case ConsoleKey.S:
                        c_style = "spinner";
                        break;
                    }
                    ReflectingActivity r1 = new ReflectingActivity("Reflecting","Take a few moments to ponder about the following:",c_style);
                    r1.SetDuration(r1.InitializeTimer());
                    r1.Run();
                break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                case ConsoleKey.L:
                    // Listing Activity.
                    ListingActivity _la = new("aName","aDesc");
                    _la.Run();
                    // Console.WriteLine("Enter your listing activity comments.");
                    // string _input = Console.ReadLine();
                    // _la.SetDuration(_la.InitializeTimer());
                    // Console.WriteLine($"You entered: {_input}");
                    // _la.GetListFromUser(_input);
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
                    // InitializeTimer();
                    Console.WriteLine("Testing.");
                    break;

                default:
                    Console.WriteLine("Something went wrong. Please try again");
                    break;
            }
        }
    }

}