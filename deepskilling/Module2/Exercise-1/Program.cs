using System;
using System.Collections.Generic;

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public Product(int productId, string productName, int quantity, double price)
    {
        ProductId = productId;
        ProductName = productName;
        Quantity = quantity;
        Price = price;
    }

    public void Display()
    {
        Console.WriteLine($"{ProductId} {ProductName} {Quantity} {Price}");
    }
}

class InventoryManagement
{
    private Dictionary<int, Product> inventory = new Dictionary<int, Product>();

    // Add Product
    public void AddProduct(Product product)
    {
        inventory[product.ProductId] = product;
        Console.WriteLine("Product Added");
    }

    // Update Product
    public void UpdateProduct(int id, int quantity, double price)
    {
        if (inventory.ContainsKey(id))
        {
            inventory[id].Quantity = quantity;
            inventory[id].Price = price;
            Console.WriteLine("Product Updated");
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }
    }

    // Delete Product
    public void DeleteProduct(int id)
    {
        if (inventory.Remove(id))
            Console.WriteLine("Product Deleted");
        else
            Console.WriteLine("Product Not Found");
    }

    // Display Products
    public void DisplayProducts()
    {
        foreach (var product in inventory.Values)
        {
            product.Display();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        InventoryManagement inventory = new InventoryManagement();

        inventory.AddProduct(new Product(101, "Laptop", 10, 55000));
        inventory.AddProduct(new Product(102, "Mouse", 50, 500));
        inventory.AddProduct(new Product(103, "Keyboard", 20, 1500));

        Console.WriteLine("\nInventory:");
        inventory.DisplayProducts();

        inventory.UpdateProduct(102, 60, 600);

        Console.WriteLine("\nAfter Update:");
        inventory.DisplayProducts();

        inventory.DeleteProduct(103);

        Console.WriteLine("\nAfter Delete:");
        inventory.DisplayProducts();
    }
}