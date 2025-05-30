using System;
using System.Globalization;

public class Order
{
  private List<Product> _products;
  private Customer _customer;

  public Order(Customer customer)
  {
    _customer = customer;
    _products = new List<Product>();
  }

  public void AddProduct(string name, int price, int quantity)
  {
    Product newProduct = new Product(name, price, quantity);
    _products.Add(newProduct);
  }

  public string GetTotalCost()
  {
    int shippingCost = _customer.IsUsa() ? 5 : 35;
    int totalCost = shippingCost;
    var usCulture = new CultureInfo("en-US");

    foreach (Product product in _products)
    {
      totalCost += product.GetTotalCost();
    }

    return $"{totalCost.ToString("C", usCulture)}";
  }

  public string GetPackingLabel()
  {
    string packingLabel = "";

    foreach (Product product in _products)
    {
      packingLabel += product.GetPackingLabel();
    }

    return packingLabel;
  }

  public string GetShippingLabel()
  {
    return _customer.GetShippingLabel();
  }
}