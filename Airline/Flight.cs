using System;
using System.Collections.Generic;

/// <summary>
/// This class stores the whole flight information
/// </summary>
public class Flight
{
    private int flightID;
    /// <summary>
    /// The FlightID property represents the ID of a Flight
    /// <value> The FlightID property gets/sets the value of the field flightID.</value>
    /// </summary>
    public int FlightID
    {
        get => flightID;
        set => flightID = value;
    }

    private string flightCode;
    /// <summary>
    /// The FlightCode property represents the Code of a Flight so the user can check his flight on
    /// the Airport's Monitors
    /// <value> The FlightCode property gets/sets the value of the field flightCode.</value>
    /// </summary>
    public string FlightCode
    {
        get => flightCode;
        set => flightCode = value;
    }

    private Aircraft flightAircraft;
    /// <summary>
    /// The FlightAircraft property represents the Aircraft of a Flight
    /// <value> The FlightAircraft property gets/sets the value of the field flightAircraft.</value>
    /// </summary>
    public Aircraft FlightAircraft
    {
        get => flightAircraft;
        set => flightAircraft = value;
    }

    private Airport flightAirportOrigin;
    /// <summary>
    /// The FlightAirportOrigin property represents the Origin Airport of a Flight
    /// <value> The FlightAirportOrigin property gets/sets the value of the field flightAirportOrigin.</value>
    /// </summary>
    public Airport FlightAirportOrigin
    {
        get => flightAirportOrigin;
        set => flightAirportOrigin = value;
    }

    private Airport flightAirportDestination;
    /// <summary>
    /// The FlightAirportDestination property represents the Destination Airport of a Flight
    /// <value> The FlightAirportDestination property gets/sets the value of the field flightAirportDestination.</value>
    /// </summary>
    public Airport FlightAirportDestination
    {
        get => flightAirportDestination;
        set => flightAirportDestination = value;
    }

    private DateTime flightArrivalTime;
    /// <summary>
    /// The FlightArrivalTime property represents the Date/Time of a Flight Arrival
    /// <value> The FlightArrivalTime property gets/sets the value of the field flightArrivalTime.</value>
    /// </summary>
    public DateTime FlightArrivalTime
    {
        get => flightArrivalTime;
        set => flightArrivalTime = value;
    }

    private DateTime flightDepartureTime;
    /// <summary>
    /// The FlightDepartureTime property represents the Date/Time of a Flight Departure
    /// <value> The FlightDepartureTime property gets/sets the value of the field flightDepartureTime.</value>
    /// </summary>
    public DateTime FlightDepartureTime
    {
        get => flightDepartureTime;
        set => flightDepartureTime = value;
    }

    private List<Seat> flightSeats;
    /// <summary>
    /// The FlightSeats property represents all the seats on a flight
    /// <value> The FlightSeats property gets/sets the value of the field flightSeats.</value>
    /// </summary>
    public List<Seat> FlightSeats
    {
        get => flightSeats;
        set => flightSeats = value;
    }

    private EmployeeAccount flightPilot;
    /// <summary>
    /// The FlightPilot property represents the Pilot
    /// <value> The FlightPilot property gets/sets the value of the field flightPilot.</value>
    /// </summary>
    public EmployeeAccount FlightPilot
    {
        get => flightPilot;
        set => flightPilot = value;
    }

    /// <summary>
    /// The FlightDuration property represents the duration of a flight
    /// </summary>
    public int FlightDuration
    {
        get => (flightArrivalTime - flightDepartureTime).Minutes;
    }

    private string flightType;
	/// <summary>
    /// FlightType stores Flight type.
    /// </summary>
    /// <value>FlightType gets flightType's string value.</value>
    public string FlightType
    {
        get => flightType;
        set => flightType = value;
    }

    public Flight()
    {        
    }

    public Flight(Aircraft aircraft)
    {
        this.FlightAircraft = aircraft;
        CreateSeats();
    }

    /// <summary>
    /// This method creates and initials the seats of flight.
    /// </summary>
    private void CreateSeats()
	{
        this.flightSeats = new List<Seat>();
        for (int i = 1; i <= this.FlightAircraft.AircraftNumberSeatsBusiness; i++)
        {
            this.FlightSeats.Add(new BusinessSeat());
        }

        for (int i = 1; i <= this.FlightAircraft.AircraftNumberSeatsEconomy; i++)
        {
            this.FlightSeats.Add(new EconomySeat());
        }

        for (int i = 1; i <= this.FlightAircraft.AircraftNumberSeatsPremiumEconomy; i++)
        {
            this.FlightSeats.Add(new PremiumEconomySeat());
        }
    }
}

