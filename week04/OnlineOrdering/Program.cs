using System;

class Program
{
    static void Main(string[] args)
    {
        // First Order
        Address address1 = new Address("123 Apple St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM123", 25.99, 2));
        order1.AddProduct(new Product("USB-C Cable", "UC456", 9.99, 3));

        Console.WriteLine("=== Order 1 ===");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine();

        // Second Order
        Address address2 = new Address("88 Tech Avenue", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Carlos Martinez", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Bluetooth Speaker", "BS789", 45.50, 1));
        order2.AddProduct(new Product("Phone Stand", "PS101", 14.75, 2));

        Console.WriteLine("=== Order 2 ===");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}
