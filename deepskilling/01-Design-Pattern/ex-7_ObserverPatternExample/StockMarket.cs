using System.Collections.Generic;

public class StockMarket : IStock
{
    private List<IObserver> observers = new();

    private string stockName;
    private double price;

    public StockMarket(string stockName)
    {
        this.stockName = stockName;
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(stockName, price);
        }
    }

    public void SetPrice(double newPrice)
    {
        price = newPrice;
        Console.WriteLine($"\n{stockName} price updated to {price}");
        NotifyObservers();
    }
}