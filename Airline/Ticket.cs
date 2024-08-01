using System;
/// <summary>
/// Ticket class holds all information about a Flight Ticket
/// </summary>
public class Ticket : IObserverTicket
{
    /// <summary>
    /// Identification of Ticket
    /// </summary>
    private int ticketID;
    public int TicketID
    {
        get => ticketID;
        set => ticketID = value;
    }

    /// <summary>
    /// Ticket has a Seat inside a flight
    /// </summary>
    private Seat ticketSeat;
    public Seat TicketSeat
    {
        get => ticketSeat;
        set => ticketSeat = value;
    }

    /// <summary>
    /// Passenger information of a Ticket
    /// </summary>
    private string ticketPassenger;
    public string TicketPassenger
    {
        get => ticketPassenger;
        set => ticketPassenger = value;
    }

    /// <summary>
    /// Cancellation Insurance of a ticket
    /// </summary>
    private CancellationInsurance ticketCancellationInsurance;
    public CancellationInsurance TicketCancellationInsurance
    {
        get => ticketCancellationInsurance;
        set => ticketCancellationInsurance = value;
    }

    /// <summary>
    /// Ticket Date of purchase
    /// </summary>
    private DateTime ticketPurchasedDate;
    public DateTime TicketPurchasedDate
    {
        get => ticketPurchasedDate;
        set => ticketPurchasedDate = value;
    }

    public int TicketPrice()
    {
        return this.TicketSeat.SeatPrice;
    }

    /// <summary>
    /// Update method called when Sale state is updated.
    /// </summary>
    /// <param name="saleState"></param>
    void IObserverTicket.Update(string saleState)
    {
        Console.WriteLine("Ticket ID : {0}, Notification: Sale state changed to {1}", TicketID, saleState);
    }

    public Ticket(int ticketID, Seat ticketSeat, string ticketPassenger)
    {
        TicketID = ticketID;
        TicketSeat = ticketSeat;
        TicketPassenger = ticketPassenger;
    }

    public Ticket()
    {
    }
}

