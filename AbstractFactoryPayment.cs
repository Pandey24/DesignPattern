//Define Abstract Factory
public interface IPaymentFactory
{
    IPaymentService CreatePaymentService();
    IRefundService CreateRefundService();
}

//Concrete Factories
public class PayPalFactory : IPaymentFactory
{
    public IPaymentService CreatePaymentService() => new PayPalPaymentService();
    public IRefundService CreateRefundService() => new PayPalRefundService();
}

public class StripeFactory : IPaymentFactory
{
    public IPaymentService CreatePaymentService() => new StripePaymentService();
    public IRefundService CreateRefundService() => new StripeRefundService();
}

//Concrete Products
public class PayPalPaymentService : IPaymentService
{
    public string ProcessPayment(decimal amount) => $"PayPal processed {amount}";
}
public class PayPalRefundService : IRefundService
{
    public string ProcessRefund(int transactionId) => $"PayPal refunded {transactionId}";
}

public class StripePaymentService : IPaymentService
{
    public string ProcessPayment(decimal amount) => $"Stripe processed {amount}";
}
public class StripeRefundService : IRefundService
{
    public string ProcessRefund(int transactionId) => $"Stripe refunded {transactionId}";
}
//Usees
public class PaymentController : ControllerBase
{
    private readonly IPaymentService _paymentService;
    private readonly IRefundService _refundService;

    public PaymentController(IPaymentFactory factory)
    {
        _paymentService = factory.CreatePaymentService();
        _refundService = factory.CreateRefundService();
    }

    [HttpGet("pay")]
    public string Pay(decimal amount) =>
        _paymentService.ProcessPayment(amount);

    [HttpGet("refund/{id}")]
    public string Refund(int id) =>
        _refundService.ProcessRefund(id);
}
