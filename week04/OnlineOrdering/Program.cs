using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Customer with Address
        Customer customer = new Customer("Levi Omagbemi", "Iyara, Edukugho", "Warri", "Delta State", "Nigeria");
        Customer customer2 = new Customer("Sarah Huxtable", "Broadway", "New York City", "New York", "America");

        Order order1 = new Order(customer);
        Order order2 = new Order(customer2);

        order1.AddProduct("Oraimo Airpod", 500, 2);
        order1.AddProduct("Logitech Wireless Mouse", 3500, 3);
        order1.AddProduct("Sony WH-1000XM4 Headphones", 25000, 1);

        order2.AddProduct("Apple iPhone 14", 150000, 1);
        order2.AddProduct("Dell XPS 13 Laptop", 450000, 2);
        order2.AddProduct("Samsung Galaxy S21", 120000, 1);

        Console.WriteLine("Order One:");
        Console.WriteLine($"Packing Label: {order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label: {order1.GetShippingLabel()}");
        Console.WriteLine($"Total: {order1.GetTotalCost()}");

        Console.WriteLine();

        Console.WriteLine("Order Two:");
        Console.WriteLine($"Packing Label: {order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label: {order2.GetShippingLabel()}");
        Console.WriteLine($"Total: {order2.GetTotalCost()}");

    }
}