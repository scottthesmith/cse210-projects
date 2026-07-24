using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class Order
{
    private Customer _customer;
    List<Product> orders = new List<Product>();
    public Order(Customer newCustomer)
    {
        _customer = newCustomer;
      
    }

    public void AddProduct(Product newProduct)
    {
        orders.Add(newProduct);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product item in orders)
        {
            totalCost += item.TotalCost();
        }

        if (_customer.IsInUSA() == true)
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public string CreateShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddressString()}";
    }

    public string CreatePackingLabel()
    {
        string packingLabel = "Packing label:\n";
        foreach (Product item in orders)
        {
            packingLabel += $"{item.GetName()} - ID: {item.GetProductID()}\n";
        }
        return packingLabel;
    } 

  
}