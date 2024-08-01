using System;
/// <summary>
/// Derive class PayPalPayment from base class PaymentMethod
/// </summary>
public class PayPalPayment : PaymentMethod
{
    /// <summary>
    /// Override ProcessPayment with PayPal Card Payment
    /// </summary>
    public override void ProcessPayment()
    {
        Console.WriteLine("Process by PayPal");
    }
}

