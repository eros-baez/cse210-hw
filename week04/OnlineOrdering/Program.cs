/*
Eros Baez
I used 3 different customer whit different products.
All the variables in classes are private.

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("Street 1", "New York", "NY", "USA");
        Address a2 = new Address("Calle 123", "La Plata", "Buenos Aires", "Argentina");
        Address a3 = new Address("Callao", "Eldorado", "Misiones", "Argentina");

        Customer c1 = new Customer("John", a1);
        Customer c2 = new Customer("Eros", a2);
        Customer c3 = new Customer("Renata", a3);

        Product p1 = new Product("Book", "A1", 10, 2);
        Product p2 = new Product("Pen", "B2", 2, 5);
        Product p3 = new Product("Laptop", "C3", 500, 1);
        Product p4 = new Product("Telephone", "D4", 400, 1);

        Order o1 = new Order(c1);
        o1.AddProduct(p1);
        o1.AddProduct(p2);

        Order o2 = new Order(c2);
        o2.AddProduct(p3);
        o2.AddProduct(p1);

        Order o3 = new Order(c3);
        o3.AddProduct(p4);
        o3.AddProduct(p2);

        Console.WriteLine("ORDER 1");
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine($"Total: {o1.GetTotalCost()}");

        Console.WriteLine("-------------------");

        Console.WriteLine("ORDER 2");
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine($"Total: {o2.GetTotalCost()}");

        Console.WriteLine("-------------------");

        Console.WriteLine("ORDER 3");
        Console.WriteLine(o3.GetShippingLabel());
        Console.WriteLine(o3.GetPackingLabel());
        Console.WriteLine($"Total: {o3.GetTotalCost()}");
    }
}