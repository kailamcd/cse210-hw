public class Address
{
    private string _street;
    private string _city;
    private string _stPrv;
    private int _zip;

    public Address(string street, string city, string stPrv, int zip)
    {
        _street = street;
        _city = city;
        _stPrv = stPrv;
        _zip = zip;
    }

    public string AddressString()
    {
        string addressString = $"{_street}\n{_city}, {_stPrv} {_zip}";
        return addressString;
    }
}