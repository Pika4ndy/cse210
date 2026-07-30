using System.Net.Http.Headers;

public class Order
{
    // Shipping cost USA: $5 else: $35
    private const double CostInUsa = 5;
    private const double CostOutUsa = 35;
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _shippingCost;

    public Order(Customer customer)
    {
        _customer = customer;

        if (_customer.IsInUSA())
        {
            _shippingCost = CostInUsa;
        } else
        {
            _shippingCost = CostOutUsa;
        }
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method: Calculate Total Cost of the order
        // Total cost of each product + 1 time shipping cost

    public double GetTotalCost()
    {
        double sum = 0;
        foreach (Product product in _products)
        {
            sum += product.GetCost();
        }

        return Math.Round(sum + _shippingCost, 2);
    }

    

    // Method: return a string for the packing label
        // name of product + product ID
    public string GetPackingLabel()
    {
        string packingLabel = "";
        int i = 0;

        foreach (Product product in _products)
        {
            i++;
            string productName = product.GetName();
            int productID = product.GetID();

            packingLabel += $"{i}. {productName} — {productID}\n";
        }

        return packingLabel;
    }

    // Method: return a string for the shipping label
        // (name + address) of customer
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }

}