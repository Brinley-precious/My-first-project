using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double productTotal = 0;
        foreach (Product product in _products)
        {
            productTotal += product.GetTotalCost();
        }

        double shippingCost = _customer.LivesInUSA() ? 5 : 35;
        return productTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        foreach (Product product in _products)
        {
            sb.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
