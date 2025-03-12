using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    private int i=0;
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");

        foreach (Job j in _jobs)
        {
            i +=1;
            Console.Write($"Job # {i}: ");
            j.Display();
        }
    }


}
