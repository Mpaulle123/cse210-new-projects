using System.Numerics;

class Order
{
    public Customer _customer{ get; private set; }
    private List<(Product, int)> _products{ get; set; }

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<(Product, int)>();
    }

    public void AddProduct(Product product, int quantity)
    {
        _products.Add((product, quantity));
    }

    private double ShippingCost()
    {
        return _customer._address._country == "USA" ? 5.00 : 35.00;
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"Customer:{_customer._name}");
        Console.WriteLine($"Address:{_customer._address}");
        Console.WriteLine("Products ordered:");
        double total = 0;
        foreach(var(product,quantity)in _products)
        {
            double subTotal = product.TotalPrice(quantity);
            Console.WriteLine($"{product._productName} (ID:{product._productId}) - Quantity: {quantity} - Unit price: {product._productPrice} - Subtotal:{subTotal}");
            Console.WriteLine($"Packing label: -Product name:{product._productName}, ID:{product._productId}");
            Console.WriteLine($"Shipping label: -Customer name:{_customer._name}, Address:{_customer._address}");
            total += subTotal;
        }

        double shippingFees = ShippingCost();
        total += shippingFees;
        Console.WriteLine($"Shipping cost is:{shippingFees}");
        Console.WriteLine($"The total cost is:{total}");
    }
}