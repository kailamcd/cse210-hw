public class Address
{
    private string _street;
    private string _city;
    private string _stPrv;
    private string _country;
    private int _zip;

    public Address(string street, string city, string stPrv, string country, int zip)
    {
        _street = street;
        _city = city;
        _stPrv = stPrv;
        _country = country;
        _zip = zip;
    }

    public string AddressString()
    {
        string addressString = $"{_street}\n{_city}, {_stPrv}, {_country}\n{_zip}";
        return addressString;
    }

    public int InUS()
    {
        if (_country == "US")
        {
            return 5;
        }
        else
        {
            return 35;
        }
        
    }
}