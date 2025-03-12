using System;

public class Job
{
    public string _company = "Some Company";
    public string _jobTitle = "Some Job Indeed";
    public DateOnly _startYear = new(2009,08,22);
    public DateOnly _endYear = new(2012, 02, 14);
    public string GetCompany()
    {
        return _company;
    }

    public void Display(){
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear.ToString("yyyy")}-{_endYear.ToString("yyyy")}");
    }
    

}