using System;

public class Address
{
  private string _streetAddress;
  private string _city;
  private string _state;
  private string _country;


  public Address(string streetAddress, string city, string state, string country)
  {
    _streetAddress = streetAddress;
    _city = city;
    _state = state;
    _country = country;
  }

  public bool IsUsa()
  {
    string country = _country.ToLower();
    return country == "usa" || country == "america";
  }

  public string GetDisplayAddress()
  {
    return $"{_streetAddress}, {_city}, {_state}, {_country}";
  }
}