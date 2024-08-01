/// <summary>
/// This class stores the Employee information
/// </summary>
public class EmployeeAccount : Account
{
	private EmployeeType employeeAccountType;
    /// <summary>
    /// The EmployeeAccountType property represents type of Employee (Pilot, Crew etc).
    /// <value> The EmployeeAccountType property gets/sets the value of the field employeeAccountType.</value>
    /// </summary>
    public EmployeeType EmployeeAccountType
    {
        get => employeeAccountType;
        set => employeeAccountType = value;
    }
}

