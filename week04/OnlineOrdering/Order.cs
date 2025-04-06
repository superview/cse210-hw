using System.Security.Cryptography.X509Certificates;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    private double _shipping = 35.00;
    private double _totalCost = 0.00;
    private int _reportRowLength = 58;
    private int _orderQuantity = 0;
    private string _shippingLabelString;
    private string _packingLabelString;
    public Order(Customer c, List<Product> p)
    {
        _customer = c;
        _products = p;
    }
    public Order(Customer c)
    {
        _customer = c;
        Product p1 = new Product("Bannana", 5234, 13.24,5);
        Product p2 = new Product("Zipper", 3338, 3.49,1);
        Product p3 = new Product("Clamp", 5853, 53.24,4);
        Product p4 = new Product("Newspaper", 1214, 2.00, 1);
        Product p5 = new Product("Vitamins", 8984, 36.19,2);
        _products.Add(p1);
        _products.Add(p2);
        _products.Add(p3);
        _products.Add(p4);
        _products.Add(p5);
    }
    public double TotalProductCost()
    {
        double _totalAllCost = 0.00;
    // total price = total cost + shipping
        foreach(Product p in _products)
        {
            _totalAllCost += p.GetCost();
            return _totalAllCost;
        }

        if(_customer.IsUSA())
        {
            _shipping = 5.00;
        }
        else
        {
            _shipping = 35.00;
        }
        _totalAllCost += _shipping;

        return _totalAllCost;
    }
    public void Display()
    {
        
        Console.WriteLine(new string('-', _reportRowLength));
        Console.WriteLine($"Order details:");
        Console.WriteLine("{0, -6}{1, -18}{2,10}{3,-4}{4,-5}{5,15}", "Code", "Product", "Unit Price", "", "Units", "Line Total");
        Console.WriteLine(new string('-', _reportRowLength));

        // Data rows
        foreach(Product p in _products)
        {
            p.Display();
            _totalCost += p.GetCost();
        }
        Console.WriteLine($"Total Cost: {_totalCost:C2}");
        if(_customer.IsUSA())
        {
            _shipping = 5.00;
        }
        Console.WriteLine($"Shipping Cost: {_shipping:C2}");
        Console.WriteLine($"Total including shipping cost: {_totalCost + _shipping:C2}");

    }
    public string GetPackingLabel()
    {
        // Can return a string for the packing label.
        _packingLabelString = new string('-', _reportRowLength);
        _packingLabelString += "\nThis is the Packing Label\n";
        _packingLabelString += "Customer:\n";
        _packingLabelString += _customer.GetCustomer();
        _packingLabelString += "\nPacking List:\n";
        _packingLabelString += "Code   Product    Units";
        // Data rows
        foreach(Product p in _products)
        {
            // p.Display("p");
            _packingLabelString += p.GetProductPack();
            _orderQuantity += p.GetQuantity();
        }

        Console.WriteLine("{0,34}",new string ('-', 4));
        Console.WriteLine("{0,-12}{1,22}","Total Items:", _orderQuantity);
        return _packingLabelString;
    }
    public void DisplayPackingLabel()
    {
        // Can return a string for the packing label.
        Console.WriteLine(new string('-', _reportRowLength));
        Console.WriteLine("This is the Packing Label");
        Console.WriteLine("");
        Console.WriteLine("Customer:");
        _customer.Display();
        Console.WriteLine("");
        Console.WriteLine("Packing List:");

        Console.WriteLine("{0, -6}{1, -18}{2,10}", "Code", "Product", "Units");
        // Data rows
        foreach(Product p in _products)
        {
            p.Display("p");
            _orderQuantity += p.GetQuantity();
        }

        Console.WriteLine("{0,34}",new string ('-', 4));
        Console.WriteLine("{0,-12}{1,22}","Total Items:", _orderQuantity);
    }

    public string GetShippingLabel()
    {
        // Can return a string for the shipping label.
        _shippingLabelString = new string('-', _reportRowLength);
        _shippingLabelString += "\nThis is the Shipping Label\n";
        _shippingLabelString += _customer.GetCustomer();
        return _shippingLabelString;
    }

    public void DisplayShippingLabel()
    {
        // Display the shipping label.
        Console.WriteLine(new string('-', _reportRowLength));
        Console.WriteLine("This is the Shipping Label");
        _customer.Display();
    }


}