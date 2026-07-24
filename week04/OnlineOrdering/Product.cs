public class Product
{
    private string _productID;
    private string _productName;
    private double _productPrice;
    private int _quantity;

    public Product(string productID, string productName, double productPrice, int quantity)
    {
       _productID = productID;
       _productName = productName;
       _productPrice = productPrice;
       _quantity = quantity;
    }

    public double TotalCost()
    {
        return _productPrice * _quantity;
    }

    public string GetName()
    {
        return _productName;
    }

    public string GetProductID()
    {
        return _productID;
    }
}