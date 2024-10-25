using System;

class Program
{
    static void Main(string[] args)
    {
        
        //addresses
        Address address1 = new Address("134 Lemon Street", "New York", "NY", "USA");
        Address address2 = new Address("12 rue Teste", "Paris", "Ile de France", "France");
        Address address3 = new Address("56 Just Street", "Los Angeles", "CA", "USA");

        //customers
        Customer customer1 = new Customer("John Mike", address1);
        Customer customer2 = new Customer("Lisa Carla", address2);
        Customer customer3 = new Customer("Bea Carlos", address3);

        //products
        Product product1 = new Product("Product 1", "ID0001", 19.00);
        Product product2 = new Product("Product 2", "ID0234", 10.00);
        Product product3 = new Product("Product 3", "ID0120", 9.00);
        Product product4 = new Product("Product 4", "ID0123", 25.00);

        //orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product2, 2);
        order1.AddProduct(product1, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4, 1);
        order2.AddProduct(product3, 2);

        Order order3 = new Order(customer3);
        order3.AddProduct(product2, 1);
        order3.AddProduct(product4, 1);

        //display of orders
        order1.DisplayOrder();
        Console.WriteLine();
        order2.DisplayOrder();
        Console.WriteLine();
        order3.DisplayOrder();

    }
}