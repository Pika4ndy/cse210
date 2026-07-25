public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public Customer(string name, string street, string city, string stateOrProvince, string country)
    {
        _name = name;
        _address = new Address(street, city, stateOrProvince, country);
    }

    // Method: isInUSA?
        // Call a method from Address

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetAddress()
    {
        return _address.GetFullAddress();
    }

    public string GetName()
    {
        return _name;
    }
}