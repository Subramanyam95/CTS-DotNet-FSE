public class PayPalAdapter : PaymentProcessor
{
    private PayPalGateway paypal;

    public PayPalAdapter(PayPalGateway paypal)
    {
        this.paypal = paypal;
    }

    public void ProcessPayment(double amount)
    {
        paypal.SendPayment(amount);
    }
}