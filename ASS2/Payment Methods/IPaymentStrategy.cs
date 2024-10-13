namespace ASS2.Payment_Methods;

public interface IPaymentStrategy
{
    void ProcessPayment(decimal amount);
}