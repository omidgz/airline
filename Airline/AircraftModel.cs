/// <summary>
/// this class implements aircraft model information
/// </summary>
public class AircraftModel
{
	private int aircraftModelId;
    /// <summary>
    /// The AircraftModelID property represents the aircraft model ID.
    /// <value> The AircraftModelID property gets/sets the value of the field aircraftModelId.</value>
    /// </summary>
    public int AircraftModelID
    {
        get => aircraftModelId;
        set => aircraftModelId = value;
    }

    private string aircraftModelName;
    /// <summary>
    /// The AircraftModelName property represents the Name or Code for the aircraft model.
    /// <value> The AircraftModelName property gets/sets the value of the field aircraftModelName.</value>
    /// </summary>
    public string AircraftModelName
    {
        get => aircraftModelName;
        set => aircraftModelName = value;
    }

    private AircraftManufacturer aircraftModelManufacturer;
    /// <summary>
    /// The AircraftModelManufacturer property represents the Aicraft Manufacture like Airbus or Boeing.
    /// <value> The AircraftModelManufacturer property gets/sets the value of the field aircraftModelManufacturer.</value>
    /// </summary>
    public AircraftManufacturer AircraftModelManufacturer
    {
        get => aircraftModelManufacturer;
        set => aircraftModelManufacturer = value;
    }
    public AircraftModel()
    {
    }

    public AircraftModel(int aircraftModelId, string aircraftModelName, AircraftManufacturer aircraftModelManufacturer)
    {
        this.aircraftModelId = aircraftModelId;
        this.aircraftModelName = aircraftModelName;
        this.aircraftModelManufacturer = aircraftModelManufacturer;
    }
}

