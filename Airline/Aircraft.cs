/// <summary>
/// this class stores aircraft information
/// </summary>
public class Aircraft
{
    private int aircraftID;
	/// <summary>
    /// this property hold aircraft identifier
    /// </summary>
	public int AircraftID
    {
        get => aircraftID;
        set => aircraftID = value;
    }

    private AircraftModel aircraftModel;
	/// <summary>
    /// this property hold aircraft model information
    /// </summary>
    public AircraftModel AircraftModel
    {
        get => aircraftModel;
        set => aircraftModel = value;
    }

    private string aircraftSerialNumber;
    /// <summary>
    /// this property hold aircraft serial number
    /// </summary>
    public string AircraftSerialNumber
    {
        get => aircraftSerialNumber;
        set => aircraftSerialNumber = value;
    }

    private int aircraftNumberSeatsEconomy;

    /// <summary>
    /// this property hold aircraft economy seats numbersr
    /// </summary>
    public int AircraftNumberSeatsEconomy
    {
        get => aircraftNumberSeatsEconomy;
        set => aircraftNumberSeatsEconomy = value;
    }

    private int aircraftNumberSeatsPremiumEconomy;
    /// <summary>
    /// this property hold aircraft premium seats numbersr
    /// </summary>
    public int AircraftNumberSeatsPremiumEconomy
    {
        get => aircraftNumberSeatsPremiumEconomy;
        set => aircraftNumberSeatsPremiumEconomy = value;
    }

    private int aircraftNumberSeatsBusiness;
    /// <summary>
    /// this property hold aircraft business seats numbersr
    /// </summary>
    public int AircraftNumberSeatsBusiness
    {
        get => aircraftNumberSeatsBusiness;
        set => aircraftNumberSeatsBusiness = value;
    }


    public Aircraft(int aircraftID, AircraftModel aircraftModel, string aircraftSerialNumber, int aircraftNumberSeatsEconomy, int aircraftNumberSeatsPremiumEconomy, int aircraftNumberSeatsBusiness)
    {
        this.aircraftID = aircraftID;
        this.aircraftModel = aircraftModel;
        this.aircraftSerialNumber = aircraftSerialNumber;
        this.aircraftNumberSeatsEconomy = aircraftNumberSeatsEconomy;
        this.aircraftNumberSeatsPremiumEconomy = aircraftNumberSeatsPremiumEconomy;
        this.aircraftNumberSeatsBusiness = aircraftNumberSeatsBusiness;
    }

    public Aircraft()
    {

    }


}

