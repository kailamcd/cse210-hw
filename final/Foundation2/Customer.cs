public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string DisplayCustomer()
    {
        // Console.WriteLine(_name);
        string a = _address.AddressString();
        // Console.WriteLine(a);
        return $"{_name}\n{a}";
    }

    public int ShippingCost()
    {
        int shipping = _address.InUS();
        return shipping;
    }
}