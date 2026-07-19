public class StripeGateway
{
    public void MakeTransaction(double amount)
    {
        Console.WriteLine($"Payment of Rs.{amount} processed through Stripe");
    }
}