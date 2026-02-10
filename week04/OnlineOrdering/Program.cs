using System;

class Program
{
    static void Main(string[] args)
    {
        //    Order 1: USA Customer
        Address addr1 = new Address("123 Maple St", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("Baguidy Mardochee", addr1);
        Order order1 = new Order(cust1);
        
        order1.AddProduct(new Product("Dell Laptop", "L404", 999.99, 1));
        order1.AddProduct(new Product("Logitech Mouse", "M202", 25.50, 2));

        //     Order 2: International
        Address addr2 = new Address("456 Sakura Blvd", "Tokyo", "Tokyo", "Japan");
        Customer cust2 = new Customer("Baguidy Tokoyo", addr2);
        Order order2 = new Order(cust2);

        order2.AddProduct(new Product("Mechanical Keyboard", "K900", 120.00, 1));
        order2.AddProduct(new Product("USB-C Cable", "C101", 15.00, 3));
        order2.AddProduct(new Product("Monitor", "V777", 300.00, 1));

        //      Display Results
        DisplayOrderDetails(order1, 1);
        Console.WriteLine(new string('-', 30));
        DisplayOrderDetails(order2, 2);
        
    }
    static void DisplayOrderDetails(Order order, int orderNumber)
    {
        Console.WriteLine($"--- RESULTS FOR ORDER {orderNumber} ---");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateOrderTotal():0.00}");
        Console.WriteLine();
    }

}