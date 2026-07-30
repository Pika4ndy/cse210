public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public Address(string street, string city, string country) // without state/province
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = "";
        _country = country;
    }

    // Method: isInUSA?
    public bool IsInUSA()
    {
        List<string> USNames = new List<string>{"USA", "US", "United States of America", "United States"};
        if (USNames.Contains(_country))
        {
            return true;
        } else
        {
          return false;  
        }
    }

    //Method: ?display full address, new line were appropriated
    public string GetFullAddress()
    {
        if (_stateOrProvince.Trim() != "")
        {
            return $"{_streetAddress}, {_city}\n{_stateOrProvince}, {_country}";
        } else
        {
            return $"{_streetAddress}, {_city}\n{_country}";
        }
    }
}