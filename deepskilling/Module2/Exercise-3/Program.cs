using System;

class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public double TotalPrice { get; set; }

    public Order(int id, string name, double price)
    {
        OrderId = id;
        CustomerName = name;
        TotalPrice = price;
    }

    public void Display()
    {
        Console.WriteLine($"{OrderId} {CustomerName} {TotalPrice}");
    }
}

class Program
{
    // Bubble Sort
    static void BubbleSort(Order[] orders)
    {
        int n = orders.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (orders[j].TotalPrice > orders[j + 1].TotalPrice)
                {
                    Order temp = orders[j];
                    orders[j] = orders[j + 1];
                    orders[j + 1] = temp;
                }
            }
        }
    }

    // Quick Sort
    static void QuickSort(Order[] orders, int low, int high)
    {
        if (low < high)
        {
            int pivot = Partition(orders, low, high);

            QuickSort(orders, low, pivot - 1);
            QuickSort(orders, pivot + 1, high);
        }
    }

    static int Partition(Order[] orders, int low, int high)
    {
        double pivot = orders[high].TotalPrice;
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (orders[j].TotalPrice < pivot)
            {
                i++;

                Order temp = orders[i];
                orders[i] = orders[j];
                orders[j] = temp;
            }
        }

        Order t = orders[i + 1];
        orders[i + 1] = orders[high];
        orders[high] = t;

        return i + 1;
    }

    static void Display(Order[] orders)
    {
        foreach (Order order in orders)
        {
            order.Display();
        }
    }

    static void Main()
    {
        Order[] orders =
        {
            new Order(101,"Rahul",4500),
            new Order(102,"Priya",2000),
            new Order(103,"Arjun",7000),
            new Order(104,"Sneha",3500),
            new Order(105,"Ravi",1500)
        };

        Console.WriteLine("Bubble Sort:");

        Order[] bubbleOrders = (Order[])orders.Clone();
        BubbleSort(bubbleOrders);
        Display(bubbleOrders);

        Console.WriteLine();

        Console.WriteLine("Quick Sort:");

        Order[] quickOrders = (Order[])orders.Clone();
        QuickSort(quickOrders, 0, quickOrders.Length - 1);
        Display(quickOrders);
    }
}