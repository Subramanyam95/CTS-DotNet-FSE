PaymentContext context = new PaymentContext();

context.SetStrategy(new CreditCardPayment());
context.ExecutePayment(5000);

context.SetStrategy(new PayPalPayment());
context.ExecutePayment(3000);