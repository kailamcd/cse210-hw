public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string productName, string productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public double GetProductPrice()
    {
        return _price;
    }

    public int GetProductQuantity()
    {
        return _quantity;
    }

    public double PricePer()
    {
        double pricePer = _price * _quantity;
        return pricePer;
    }


}