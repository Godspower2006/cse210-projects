using System;

public class Product
{
    // Private member variables
    private string _name;
    private int _productId;
    private decimal _pricePerUnit;
    private int _quantity;

    // Constructor
    public Product(string name, int productId, decimal pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    // Public getters
    public string Name => _name;
    public int ProductId => _productId;
    public decimal PricePerUnit => _pricePerUnit;
    public int Quantity => _quantity;

    // Calculates total cost = pricePerUnit * quantity
    public decimal CalculateTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    // Returns a one‐line display string (name, ID, unit price, quantity, total)
    public string GetDisplayString()
    {
        return $"Name: {_name}, ID: {_productId}, Unit Price: {_pricePerUnit:C}, Quantity: {_quantity}, Total: {CalculateTotalCost():C}";
    }
}
