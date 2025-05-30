using System;

public class Customer
{
  private string _name;
  private Address _address;

  public Customer(string name, string streetAddress, string city, string state, string country)
  {
    _name = name;
    _address = new Address(streetAddress, city, state, country);
  }

  public bool IsUsa()
  {
    return _address.IsUsa();
  }

  public string GetShippingLabel()
  {
    return $"Name: {_name}\nAddress: {_address.GetDisplayAddress()}\n";
  }
}