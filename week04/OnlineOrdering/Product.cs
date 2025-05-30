using System;

public class Product
{
  private string _name;
  private string _productId;
  private int _price;
  private int _quantity;


  public Product(string name, int price, int quantity)
  {
    Random rnd = new Random();
    // Generate a random 5-digit numeric ID as a string
    string randomId = rnd.Next(10000, 99999).ToString();


    _name = name;
    _productId = randomId;
    _price = price;
    _quantity = quantity;
  }

  public int GetTotalCost()
  {
    return _price * _quantity;
  }

  public string GetPackingLabel()
  {
    return $"Product Name {_name}\nProduct Id: {_productId}\n\n";
  }
}