using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        bool _loop = true;
        int scripture_selection = 0;
        Console.Clear();
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        int scripture_count = 0; 
        // create list of scriptures
        List<Scripture> _scripture_list = new List<Scripture> ();
        // create first scripture
        string scripture_input1 = "And men are instructed sufficiently that they know good from evil. And the law is given unto men. And by the law no flesh is justified; or, by the law men are cut off. Yea, by the temporal law they were cut off; and also, by the spiritual law they perish from that which is good, and become miserable forever.";
        Scripture _scripture = new Scripture(new Reference( "2 Nephi",  2, 5), scripture_input1);
        _scripture_list.Add(_scripture);
        scripture_count ++;
        

        // add with inline content
        _scripture_list.Add(new Scripture(new Reference("Proverbe",15,1), "A soft answer turneth away wrath: but grievous words stir up anger."));
        scripture_count ++;
        
        _scripture_list.Add(new Scripture(new Reference("1 John",1,1,5), "In the beginning was the Word, and the Word was with God, and the Word was God.  2 The same was in the beginning with God.  3 All things were made by him; and without him was not any thing made that was made. In him was life; and the life was the light of men. And the light shineth in darkness; and the darkness comprehended it not."));
        scripture_count ++;
        
        _scripture_list.Add(new Scripture(new Reference("Moroni",10,4,5), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things."));
        scripture_count ++;
        
        while (_loop)
        {
            Console.WriteLine($"Please select from the following actions: ");
            Console.WriteLine("1. Hide a random word");
            Console.WriteLine("2. Display all scriptures");
            Console.WriteLine("3. Select a random scripture");
            // Console.WriteLine("4. Save");
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
                case ConsoleKey.A:
                    // Hide another word if there are still words to hide
                    if(_scripture_list[scripture_selection].visible_words>0)
                    {
                        _scripture_list[scripture_selection].HideRandomWords();
                    }
                    else
                    {
                        Console.WriteLine("\n++++++++++++++++++++++++++++++++++");
                        Console.WriteLine("Congratulations! You have hidden all the words.\nExiting.");
                        _loop = false;
                        break;
                    }
                    
                    Console.Clear();
                    _scripture_list[scripture_selection].DisplayAll();
                    
                    
                    //_scripture.HideRandomWords(3);


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
                    scripture_selection = _scripture.GetRandomScripture(scripture_count);
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
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