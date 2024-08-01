using System;
/// <summary>
/// Derive class CreditPayment from base class PaymentMethod
/// </summary>
public class CreditPayment : PaymentMethod
{
    /// <summary>
    /// Override ProcessPayment with Credit Card Payment
    /// </summary>
    public override void ProcessPayment()
    {
        Console.WriteLine("Process by PayPal");
    }
}

