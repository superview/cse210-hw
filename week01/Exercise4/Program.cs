using System;
using System.Collections.Generic;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response_str = "";
        int sum = 0;
        double average = 0.0;
        int largest = 0;

        List<int> anum = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (response_str != "0")
        {
            Console.Write("Enter number: ");
            response_str = Console.ReadLine();
            if (int.TryParse(response_str, out int response_int))
            {
                if (response_int != 0)
                {
                    anum.Add(response_int);
                }
            }
        }

        foreach (int i in anum)
        {
            sum += i;
            if (i > largest)
            {
                largest = i;
            }
            Console.WriteLine(i);
        }
        
        Console.WriteLine("The sum is: " + sum);
        average = ((float)sum) / anum.Count;
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + largest);

    }
}