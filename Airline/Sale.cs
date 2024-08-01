using System.Collections.Generic;

/// <summary>
/// This class stores the whole Sale information
/// </summary>
public class Sale
{
	private int saleID;
    /// <summary>
    /// The SaleID property represents the ID of a Sale
    /// <value> The SaleID property gets/sets the value of the field saleID.</value>
    /// </summary>
    public int SaleID
    {
        get => saleID;
        set => saleID = value;
    }

    private Account saleCustomer;
    /// <summary>
    /// The SaleCustomer property represents the Customer who owns a Sale
    /// <value> The SaleCustomer property gets/sets the value of the field saleCustomer.</value>
    /// </summary>
    public Account SaleCustomer
    {
        get => saleCustomer;
        set => saleCustomer = value;
    }

    private List<IObserverTicket> saleTickets;
    /// <summary>
    /// The SaleTickets property represents the list of tickets included in a sale
    /// <value> The SaleTickets property gets/sets the value of the field SaleTickets.</value>
    /// </summary>
    public List<IObserverTicket> SaleTickets
    {
        get => saleTickets;
        set => saleTickets = value;
    }

    /// <summary>
    /// The SaleTotalPrice property represents the total amount paid for a sale
    /// <value> The SaleTotalPrice property gets the value of the method getTotalPrice().</value>
    /// </summary>
    public int SaleTotalPrice
    {
        get => getTotalPrice();
    }

    private PaymentMethod paymentMethod;
    /// <summary>
    /// The PaymentMethod property represents the payment method used for a sale
    /// <value> The PaymentMethod property gets the value of the method paymentMethod.</value>
    /// </summary>
    public PaymentMethod PaymentMethod
    {
        get => paymentMethod;
        set => paymentMethod = value;
    }

    private string saleState;
    /// <summary>
    /// The SaleState property represents the status of a sale
    /// <value> The SaleState property gets the value of the method saleState.</value>
    /// </summary>
    public string SaleState
    {
        get => saleState;
        set
        {
            saleState = value;
            this.Notify();
        }
    }   

    public void Purchase()
	{

	}

    /// <summary>
    /// This method returns the final price of a sale
    /// </summary>
    /// <returns>Sum of each Ticket's Price</returns>
    private int getTotalPrice()
    {
        int TotalPrice = 0;

        foreach (Ticket t in SaleTickets)
        {
            TotalPrice += t.TicketPrice();
        }

        return TotalPrice;
    }

    /// <summary>
    /// Notifies all tickets from this sale that the sale state changed.
    /// </summary>
	public void Notify()
	{
        foreach (IObserverTicket ticket in SaleTickets) {
            ticket.Update(this.saleState);
        }
	}
}

