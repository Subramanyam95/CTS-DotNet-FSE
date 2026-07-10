using System;

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }

    public void Display()
    {
        Console.WriteLine($"{ProductId} {ProductName} {Category}");
    }
}

class Program
{
    // Linear Search
    static Product LinearSearch(Product[] products, string name)
    {
        foreach (Product product in products)
        {
            if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return product;
            }
        }
        return null;
    }

    // Binary Search
    static Product BinarySearch(Product[] products, string name)
    {
        int low = 0;
        int high = products.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            int result = string.Compare(products[mid].ProductName, name, true);

            if (result == 0)
                return products[mid];
            else if (result < 0)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        // Array should be sorted by ProductName for Binary Search
        Product[] products =
        {
            new Product(101, "Keyboard", "Electronics"),
            new Product(102, "Laptop", "Electronics"),
            new Product(103, "Mouse", "Electronics"),
            new Product(104, "Phone", "Electronics"),
            new Product(105, "Printer", "Electronics")
        };

        Console.WriteLine("Linear Search:");
        Product p1 = LinearSearch(products, "Mouse");

        if (p1 != null)
            p1.Display();
        else
            Console.WriteLine("Product Not Found");

        Console.WriteLine();

        Console.WriteLine("Binary Search:");
        Product p2 = BinarySearch(products, "Mouse");

        if (p2 != null)
            p2.Display();
        else
            Console.WriteLine("Product Not Found");
    }
}