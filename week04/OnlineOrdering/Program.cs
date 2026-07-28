using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        //Addresses here
        Address usa = new Address("1313 S. Harbor Blvd.", "Anaheim", "California", "USA");
        Address intntl = new Address("His Majesty The King", "Buckingham Palace", "London SW1A 1AA", "United Kingdom");
        
        //Customers here
        Customer usaCustomer = new Customer("Mickey Mouse", usa);
        Customer intntlCustomer = new Customer("King Arthur", intntl);

        //Products here
        Product p1 = new Product("3322", "White Gloves", 99.99, 2);
        Product p2 = new Product("3323", "Magical Lake Sword", 9999.99, 1);
        Product p3 = new Product("3324", "Giant yellow shoes", 55.00, 2);
        Product p4 = new Product("3325", "Very Nice Cup", 100000000000000.99, 1);

        //Orders here
        Order order1 = new Order(usaCustomer);
        Order order2 = new Order(intntlCustomer);

        order1.AddProduct(p1);
        order1.AddProduct(p3);

        order2.AddProduct(p2);
        order2.AddProduct(p4);

        Console.WriteLine("===================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("===================================");
        Console.WriteLine(order1.CreatePackingLabel());
        Console.WriteLine("Shipping To:");
        Console.WriteLine(order1.CreateShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalCost()}");
        Console.WriteLine("");

        Console.WriteLine("===================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("===================================");
        Console.WriteLine(order2.CreatePackingLabel());
        Console.WriteLine("Shipping To:");
        Console.WriteLine(order2.CreateShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalCost()}");
        Console.WriteLine("");








    }
}