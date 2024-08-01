/// <summary>
/// This class stores the Cancellation Insurance information
/// </summary>
public class CancellationInsurance
{
	private int cancellationInsuranceID;
    /// <summary>
    /// The CancellationInsuranceID property represents the Insurance ID.
    /// <value> The CancellationInsuranceID property gets/sets the value of the field cancellationInsuranceID.</value>
    /// </summary>
    public int CancellationInsuranceID
    {
        get => cancellationInsuranceID;
        set => cancellationInsuranceID = value;
    }

    private string cancellationInsuranceName;
    /// <summary>
    /// The CancellationInsuranceName property represents the Insurance's Name.
    /// <value> The CancellationInsuranceName property gets/sets the value of the field cancellationInsuranceName.</value>
    /// </summary>
    public string CancellationInsuranceName
    {
        get => cancellationInsuranceName;
        set => cancellationInsuranceName = value;
    }

    private string cancellationInsuranceDescription;
    /// <summary>
    /// The CancellationInsuranceDescription property describe the Insurance detail.
    /// <value> The CancellationInsuranceDescription property gets/sets the value of the field cancellationInsuranceDescription.</value>
    /// </summary>
    public string CancellationInsuranceDescription
    {
        get => cancellationInsuranceDescription;
        set => cancellationInsuranceDescription = value;
    }

    private int cancellationInsurancePrice;
    /// <summary>
    /// The CancellationInsurancePrice property represents the price of an Insurance.
    /// <value> The CancellationInsurancePrice property gets/sets the value of the field cancellationInsurancePrice.</value>
    /// </summary>
    public int CancellationInsurancePrice
    {
        get => cancellationInsurancePrice;
        set => cancellationInsurancePrice = value;
    }
}

