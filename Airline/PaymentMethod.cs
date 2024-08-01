/// <summary>
/// This is Factory Method pattern apply for Payment. 
/// </summary>
public abstract class PaymentMethod
{
    /// <summary>
    /// Abstract method ProcessPayment will be overrided by derive class
    /// </summary>
    public abstract void ProcessPayment();
}

