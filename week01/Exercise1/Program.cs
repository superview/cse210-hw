using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        string fname = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string lname = Console.ReadLine();

        Console.WriteLine($"Your name is {fname}, {fname} {lname}.");
        Person p = new Person();
        
        string aaa = p.GetInformalSignature();
        Console.WriteLine(aaa);
        Console.WriteLine($"{p.GetFormalSignature()}");

    }
}