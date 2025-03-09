using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.ReadLine returns a string object
        string response = "";
        int myGuess = -1;


        // Get magic number from user
        Console.WriteLine("What is the magic number? (or any character to auto-generate a random number)");
        response = Console.ReadLine();
        if (! int.TryParse(response, out int magic))
        {
            Console.WriteLine("Generating a random number between 1 and 100");
            Random randomGenerator = new Random();

            magic = randomGenerator.Next(1, 101);
        }
        else
        {
            // Convert the input string to a number
            magic = int.Parse(response);
        }

        while(myGuess != magic)
        {
            // Get guess from user
            Console.WriteLine("What is your guess number? ");
            response = Console.ReadLine();

            // Convert the string to a number
            myGuess = int.Parse(response);

            if(myGuess == magic)
            {
                Console.WriteLine("You guessed it!");
            }
            else if(myGuess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (myGuess < magic)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Something went wrong.");
            }
        }
    }
}