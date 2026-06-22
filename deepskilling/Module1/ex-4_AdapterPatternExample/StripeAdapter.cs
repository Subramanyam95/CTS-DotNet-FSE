public class StripeAdapter : PaymentProcessor
{
    private StripeGateway stripe;

    public StripeAdapter(StripeGateway stripe)
    {
        this.stripe = stripe;
    }

    public void ProcessPayment(double amount)
    {
        stripe.MakeTransaction(amount);
    }
}