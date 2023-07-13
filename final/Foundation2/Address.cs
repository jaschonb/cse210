public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    // Returns true if address is in the USA or
    // false if not
    public bool LivesInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        return false;
    }

    // Returns a string with the address' details
    // in proper address format
    public string GetAddressString()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}