using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Address address1 = new Address("1546 Henderson Rd.","Fayetteville","TN.","USA");
        Customer customer1 = new Customer("Ramond Bettinger", address1);
        Order order1 = new Order(customer1);

        Product p1 = new Product("Bicycle", 5444, 130.24,1);
        Product p2 = new Product("Mouse Pad", 9832, 3.49,10);
        Product p3 = new Product("File Folder", 2981, 53.24,40);
        List<Product> _Plists = new List<Product>();

        _Plists.Add(p1);
        _Plists.Add(p2);
        _Plists.Add(p3);

        Address address2 = new Address("92081 Oliander St.","Carsonville","Victoria.","BC");
        Customer customer2 = new Customer("Harriett Smanger", address2);
        Order order2 = new Order(customer2, _Plists);

        Console.WriteLine(new string ('=', 64));
        customer1.Display();
        order1.Display();
        order1.TotalProductCost();
        order1.DisplayPackingLabel();
        // order.DisplayShippingLabel();
        // Console.WriteLine(order1.GetShippingLabel());
        // Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(new string ('=', 64));
        customer2.Display();
        order2.Display();
        order2.TotalProductCost();
        order2.DisplayPackingLabel();

    }
}