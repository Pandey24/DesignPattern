public interface IPaymentService
{
    string ProcessPayment(decimal amount);
}

public class PayPalService : IPaymentService
{
    public string ProcessPayment(decimal amount) => "Paid using PayPal";
}

public class StripeService : IPaymentService
{
    public string ProcessPayment(decimal amount) => "Paid using Stripe";
}

public class PaymentFactory
{
    public static IPaymentService GetPaymentService(string type)
    {
        return type switch
        {
            "PayPal" => new PayPalService(),
            "Stripe" => new StripeService(),
            _ => throw new ArgumentException("Invalid payment type")
        };
    }
}

// Usage in Controller
var service = PaymentFactory.GetPaymentService("PayPal");
string result = service.ProcessPayment(100);
