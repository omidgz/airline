/// <summary>
/// this class stores the Aircraft Manufacturers information
/// </summary>
public class AircraftManufacturer
{
    private int aircraftManufactorID;
	/// <summary>
    /// stores manufacturers identifier
    /// </summary>
    public int AircraftManufactorID
    {
        get => aircraftManufactorID;
        set => aircraftManufactorID = value;
    }

    private string aircraftManufactorName;
    /// <summary>
    /// stores manufacturers name
    /// </summary>
    public string AircraftManufactorName
    {
        get => aircraftManufactorName;
        set => aircraftManufactorName = value;
    }

    public AircraftManufacturer()
    {
    }

    public AircraftManufacturer(int aircraftManufactorID, string aircraftManufactorName)
    {
        this.aircraftManufactorID = aircraftManufactorID;
        this.aircraftManufactorName = aircraftManufactorName;
    }
}

