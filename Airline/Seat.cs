/// <summary>
/// This class stores the information of each seat on a Flight
/// </summary>
public abstract class Seat
{
    private int seatID;
    /// <summary>
    /// The SeatID property represents the ID of a Seat
    /// <value> The SeatID property gets/sets the value of the field seatID.</value>
    /// </summary>
    public int SeatID
    {
        get => seatID;
        set => seatID = value;
    }

    private string seatNumber;
    /// <summary>
    /// The SeatNumber property represents the Code of a Seat that will be used to 
    /// identify this seat in a flight
    /// <value> The SeatNumber property gets/sets the value of the field seatNumber.</value>
    /// </summary>
    public string SeatNumber
    {
        get => seatNumber;
        set => seatNumber = value;
    }

    private bool seatAvailability;
    /// <summary>
    /// The SeatAvailability property represents if a Seat is available to purchase or not
    /// <value> The SeatAvailability property gets/sets the value of the field seatAvailability.</value>
    /// </summary>
    public bool SeatAvailability
    {
        get => seatAvailability;
        set => seatAvailability = value;
    }
    
    private int seatPrice;
    /// <summary>
    /// The SeatPrice property represents the price of Seat position on a flight
    /// <value> The SeatPrice property gets/sets the value of the field seatPrice.</value>
    /// </summary>
    public int SeatPrice
    {
        get => seatPrice;
        set => seatPrice = value;
    }

    private int seatRefundExpiration;
    /// <summary>
    /// The SeatRefundExpiration property represents how many days for the Seat's Refund Expiration.
    /// <value> The SeatRefundExpiration property gets/sets the value of the field seatRefundExpiration.</value>
    /// </summary>
    public int SeatRefundExpiration
    {
        get => seatRefundExpiration;
        set => seatRefundExpiration = value;
    }

    /// <summary>
    /// Displays the Refund Period
    /// </summary>
    public abstract void DisplayRefundPeriod();
}

