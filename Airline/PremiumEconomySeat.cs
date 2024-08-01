using System;

public class PremiumEconomySeat : Seat
{
    public PremiumEconomySeat()
    {
        this.SeatRefundExpiration = 48;
    }

    public override void DisplayRefundPeriod()
    {
        Console.WriteLine("The period refund of Premium Economy Seat is {0} hours", SeatRefundExpiration);
    }
}

