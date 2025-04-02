using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Address a = new Address("1546 Henderson Rd.","Fayetteville","TN","USA");
        Customer c = new Customer("Ramond Bettinger", a);
        Order o = new Order(c);
        c.Display();
        a.Display();
        o.Display();
    }
}