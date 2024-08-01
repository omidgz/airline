/// <summary>
/// Factory Method class
/// </summary>
public class PaymentFactory
{
    /// <summary>
    /// Decide which method will be used by input paymentType
    /// </summary>
    /// <param name="paymentType">indicate if PayPal or Credit payment will be used</param>
    /// <returns>PayPalPayment or CreditPayment</returns>
	public PaymentMethod ProcessPayment(string paymentType)
	{
		switch(paymentType)
        {
            case "PayPal":
                return new PayPalPayment();
            case "Credit":
                return new CreditPayment();
            default:
                return null;
        }
	}
}

