using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> ps = new List<Product>();

        Order o1= new Order(new Customer("Benjamin Walker", new Address("220 Chesnut St.", "Port Allegany", "PA", "US", 16743)));
        Product p1 = new Product("apples", "fr35", .50, 5);
        ps.Add(p1);
        Product p2 = new Product("lbs bananas", "fr33", .33, 3);
        ps.Add(p2);
        Product p3 = new Product("lbs grapes", "fr72", 4.99, 2);
        ps.Add(p3);

        // display shipping label for first order
        Console.WriteLine(o1.ShippingLabel());

        // generate packing label
        foreach (Product product in ps)
        {
            Console.WriteLine(o1.PackingLabel(product));
        }
        Console.WriteLine($"Total Price: {o1.TotalPrice(ps)}");
        ps.Clear();
        Console.WriteLine();
        // Console.WriteLine(o1.PackingLabel(product));

        // new order
        Order o2 = new Order(new Customer("Motilal Joshi", new Address("54, Main Market, Edward Lane", "Delhi", "Delhi", "India", 110009)));
        Product p4 = new Product("Nike Air", "nka30", 123.00, 1);
        ps.Add(p4);
        Product p5 = new Product("Coconut Oil", "npo12", 7.99, 1);
        ps.Add(p5);
        Product p6 = new Product("Pringles", "npo98", 3.5, 3);
        ps.Add(p6);
        // display shipping label
        Console.WriteLine(o2.ShippingLabel());

        // generate packing label
        foreach (Product product in ps)
        {
            Console.WriteLine(o2.PackingLabel(product));
        }
        Console.WriteLine($"Total Price: {o2.TotalPrice(ps)}");
        }
}