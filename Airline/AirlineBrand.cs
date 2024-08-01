
/// <summary>
/// This class stores Airlines' information
/// </summary>
public class AirlineBrand
{
    private int airlineBrandID;
    /// <summary>
    /// The AirlineBrandID property represents the Airline Brand ID.
    /// <value> The AirlineBrandID property gets/sets the value of the field airlineBrandID.</value>
    /// </summary>
    public int AirlineBrandID
    {
        get => airlineBrandID;
        set => airlineBrandID = value;
    }

    private string airlineBrandName;
    /// <summary>
    /// The AirlineBrandName property represents the Airline Name like Air Canada, United.
    /// <value> The AirlineBrandName property gets/sets the value of the field airlineBrandName.</value>
    /// </summary>
    public string AirlineBrandName
    {
        get => airlineBrandName;
        set => airlineBrandName = value;
    }

	private AircraftCollection airlineBrandAircraftCollection;
    /// <summary>
    /// The AirlineBrandAircraftCollection property represents all Aircrafts from a specific Airline.
    /// <value> The AirlineBrandAircraftCollection property gets/sets the value of the field airlineBrandAircraftCollection.</value>
    /// </summary>
    public AircraftCollection AirlineBrandAircraftCollection
    {
        get => airlineBrandAircraftCollection;
        set => airlineBrandAircraftCollection = value;
    }
}

