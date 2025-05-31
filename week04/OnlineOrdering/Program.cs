using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // --- Create Address + Customer pairs ---
        var address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        var customer1 = new Customer("John Doe", address1);

        var address2 = new Address("456 Elm Rd", "Toronto", "ON", "Canada");
        var customer2 = new Customer("Jane Smith", address2);

        // --- Create Order #1 for customer1 ---
        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Widget",     101,  9.99m, 3));
        order1.AddProduct(new Product("Gadget",     102, 14.50m, 2));

        // --- Create Order #2 for customer2 ---
        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Thingamajig", 201,  4.75m, 5));
        order2.AddProduct(new Product("Doodad",      202,  7.20m, 1));

        // Put both orders into a list
        var orders = new List<Order> { order1, order2 };

        // Display each order’s packing label, shipping label, and total
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetDisplayString());
            Console.WriteLine(new string('-', 40));
        }
    }
}
