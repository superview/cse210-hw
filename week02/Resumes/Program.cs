using System;
using Microsoft.Win32.SafeHandles;
using static Job;

class Program
{
    static void Main(string[] args)
    {
        // create first job
        Job job1 = new Job();
        job1._jobTitle = "Engineer";
        job1._company = "The best company Co.";
        job1._startYear = DateOnly.Parse("2021-09-12");
        job1._endYear = DateOnly.Parse("2024-09-12");
        
        // create second job
        Job job2 = new Job();
        job2._jobTitle = "Jr. Engineer";
        job2._company = "Wizzard Ware";
        job2._startYear = DateOnly.Parse("2006-09-09");
        job2._endYear = DateOnly.Parse("2009-02-20");

        // job1.Display();
        // job2.Display();

        // test Resume class
        Resume resume = new Resume();
        resume._name = "John Doe";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
        
    }
}