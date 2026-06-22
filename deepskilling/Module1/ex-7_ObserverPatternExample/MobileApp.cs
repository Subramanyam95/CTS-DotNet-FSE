public class MobileApp : IObserver
{
    private string user;

    public MobileApp(string user)
    {
        this.user = user;
    }

    public void Update(string stockName, double price)
    {
        Console.WriteLine(
            $"Mobile App ({user}): {stockName} = ₹{price}"
        );
    }
}