using System;
using System.Collections.Generic;

public class Order
{
    // Private member variables
    private List<Product> _productList;
    private Customer _customer;

    // Constructor: requires a Customer, and initializes an empty product list
    public Order(Customer customer)
    {
        _customer = customer;
        _productList = new List<Product>();
    }

    // Add a product to this order
    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }

    // Calculates the one‐time shipping cost:
    //   $5 if customer is in the USA, otherwise $35
    private decimal GetOneTimeShippingCost()
    {
        return _customer.IsInUSA() ? 5m : 35m;
    }

    // Loops through each Product, sums up CalculateTotalCost(), then adds one‐time shipping
    public decimal CalculateOrderTotal()
    {
        decimal total = 0m;
        foreach (var product in _productList)
        {
            total += product.CalculateTotalCost();
        }
        total += GetOneTimeShippingCost();
        return total;
    }

    // Builds the packing label: for each product, show Name and ProductId (on separate lines)
    public string GetPackingLabelString()
    {
        // Each product line: "<Name> (ID: <productId>)"
        var label = "";
        foreach (var product in _productList)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label.TrimEnd('\n'); // remove trailing newline
    }

    // Builds the shipping label: shows customer's name + address
    public string GetShippingLabelString()
    {
        return _customer.GetDisplayString();
    }

    // Returns a multi‐line string containing packing label, shipping label, and total price
    public string GetDisplayString()
    {
        string packing = "PACKING LABEL:\n" + GetPackingLabelString();
        string shipping = "SHIPPING LABEL:\n" + GetShippingLabelString();
        string total  = $"TOTAL (including shipping): {CalculateOrderTotal():C}";

        return $"{packing}\n\n{shipping}\n\n{total}";
    }
}
