using System;
/// <summary>
/// This class stores Business Seat's Refund information
/// </summary>
public class BusinessSeat : Seat
{

    public BusinessSeat()
    {
        this.SeatRefundExpiration = 96;
    }

    public override void DisplayRefundPeriod()
    {
        Console.WriteLine("The period refund of Business Seat is {0} hours", SeatRefundExpiration);
    }
}

