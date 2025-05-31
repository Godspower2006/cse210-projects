using System;

public class Customer
{
    // Private member variables
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Public getters
    public string Name => _name;
    public Address Address => _address;

    // Returns whether this customer lives in the USA
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Returns Name + Address.GetFullAddress() on separate lines
    public string GetDisplayString()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}
