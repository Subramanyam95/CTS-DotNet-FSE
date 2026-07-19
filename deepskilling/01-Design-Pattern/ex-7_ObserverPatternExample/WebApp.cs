public class WebApp : IObserver
{
    private string user;

    public WebApp(string user)
    {
        this.user = user;
    }

    public void Update(string stockName, double price)
    {
        Console.WriteLine(
            $"Web App ({user}): {stockName} = ₹{price}"
        );
    }
}