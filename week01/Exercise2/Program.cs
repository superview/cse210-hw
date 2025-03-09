using System;

class Program
{
    static void Main(string[] args)
    {
        string grade = "tt";
        string valueInText = "42";
        int int_grade = 0;

        Console.Write("Hello.\nWhat is your grade percentage? ");
        valueInText = Console.ReadLine();
        int_grade = int.Parse(valueInText);

        if (int_grade >= 90)
        {
            grade = "A";
        }
        else if (int_grade >= 80)
        {
            grade = "B";
        }

        else if (int_grade >= 70)
        {
            grade = "C";
        }

        else if (int_grade >= 60)
        {
            grade = "D";
        }

        else if (int_grade < 60)
        {
            grade = "F";
        }

        else
        {
            Console.WriteLine("Something went wrong");
        }
        
        Console.WriteLine("Your grade is: " + grade + );

        if (int_grade > 70)
        {
            Console.WriteLine("Congratulations you passed.");
        }
        else
        {
            Console.WriteLine("Remember to keep trying.");
        }

    }
}