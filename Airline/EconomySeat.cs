using System;
/// <summary>
/// This class stores Economy Seat's Refund information
/// </summary>
public class EconomySeat : Seat
{
    public EconomySeat()
    {
        this.SeatRefundExpiration = 24;
    }

    public override void DisplayRefundPeriod()
    {
        Console.WriteLine("The period refund of Economy Seat is {0} hours", SeatRefundExpiration);
    }
}

