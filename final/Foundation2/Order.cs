public class Order
{
    private List<Product> _products;
    private Customer _c;
    private double _totalPrice;
    private string _shippingLabel;
    private string _packingLabel;
    
    public Order(Customer c)
    {
        _products = new List<Product>();
        _c = c;
        // _c.DisplayCustomer();

    }

    public string PackingLabel(Product product)
    {
        string name = product.GetProductName();
        string id = product.GetProductID();

        // Console.WriteLine();
        // Console.WriteLine("Packing List:");
        // foreach (Product product in products)
        // {
        //     string name = product.GetProductName();


        //     _totalPrice += price;
        _packingLabel = $"{id} | {name}";
        // }
        
        return _packingLabel;

    }

    public string ShippingLabel()
    {
        _shippingLabel = _c.DisplayCustomer();
        return _shippingLabel;
    }

    public string TotalPrice(List<Product> products)
    {
        double shipping = _c.ShippingCost();
        
        foreach (Product product in products)
        {
            double price = product.PricePer();
            _totalPrice += price;
        }
        _totalPrice += shipping;
        return $"${_totalPrice.ToString("0.##")}";
    }
    // Console.WriteLine($"{quantity} {name}: ${stringPrice}");

    // public string PackingString(List<Product> products)
    // {

    // }
}