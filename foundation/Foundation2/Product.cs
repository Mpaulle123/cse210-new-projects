using System.Security.Cryptography.X509Certificates;

class Product
{
    public string _productName{ get; private set;}
    public string _productId { get; private set;}
    public double _productPrice{ get; private set;}

    public Product(string productName, string productId, double productPrice)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
    }

    public double TotalPrice(int quantity)
    {
        return _productPrice * quantity;
    }




}