using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment _local = new Assignment("Jane Doe","Multiplication");
        Console.WriteLine(_local.GetSummary());
        MathAssignment _math = new MathAssignment("G. I. Joe","Fractions", "Section 4.12", "Problems 1,3,7-14");
        Console.WriteLine(_math.GetHomeworkList());
        WritingAssignment _writing = new WritingAssignment("Jamie Ranken", "Skillbuilding", "Writing for Fun");
        Console.WriteLine(_writing.GetSummary());
        Console.WriteLine(_writing.GetWritingAssignment());

    }
}