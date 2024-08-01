/// <summary>
/// This class stores the Type of Employee information
/// </summary>
public class EmployeeType
{
	private int employeeTypeID;
    public int EmployeeTypeID
    {
        get => employeeTypeID;
        set => employeeTypeID = value;
    }

    private string employeeTypeName;
    /// <summary>
    /// The EmployeeTypeName property represents job position of an Employee (Pilot, Crew etc).
    /// <value> The EmployeeTypeName property gets/sets the value of the field employeeTypeName.</value>
    /// </summary>
    public string EmployeeTypeName
    {
        get => employeeTypeName;
        set => employeeTypeName = value;
    }
}

