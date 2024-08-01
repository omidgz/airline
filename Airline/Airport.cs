/// <summary>
/// This class stores an Airport information
/// </summary>
public class Airport
{
	private int airportID;
    /// <summary>
    /// The AirportID property represents the Airport ID.
    /// <value> The AirportID property gets/sets the value of the field airportID.</value>
    /// </summary>
    public int AirportID
    {
        get => airportID;
        set => airportID = value;
    }

    private string airportName;
    /// <summary>
    /// The AirportName property represents the Airport Name.
    /// <value> The AirportName property gets/sets the value of the field airportName.</value>
    /// </summary>
    public string AirportName
    {
        get => airportName;
        set => airportName = value;
    }

    private string airportCode;
    /// <summary>
    /// The AirportCode property represents the 3 letter code that represent an Airport.
    /// <value> The AirportCode property gets/sets the value of the field airportCode.</value>
    /// </summary>
    public string AirportCode
    {
        get => airportCode;
        set => airportCode = value;
    }

    private string airportCity;
    /// <summary>
    /// The AirportCity property represents the location of an Airport.
    /// <value> The AirportCity property gets/sets the value of the field airportCity.</value>
    /// </summary>
    public string AirportCity
    {
        get => airportCity;
        set => airportCity = value;
    }
}

