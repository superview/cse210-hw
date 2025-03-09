using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int fav_number = PromptUserNumber();
        // Console.WriteLine($"{name}, the square of your number is {fav_number **2}" );
        int mySquare = SquareNumber(fav_number);
        DisplayResult(name, mySquare);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Hello there! Welcome to the program.");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name: ");
        string response = Console.ReadLine();
        return response;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number: ");
        string response = Console.ReadLine();
        int.TryParse(response, out int int_response);
        return int_response;
    }

    static int SquareNumber(int number)
    {
        int sqr = number * number;
        return sqr;
    }
    static void  DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}