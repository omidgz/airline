/// <summary>
/// this class represents Account basic structure that we will use in our application.
/// </summary>
public abstract class Account
{
    private int accountID;
    /// <summary>
    /// This property stores Account ID
    /// </summary>
    public int AccountID
    {        
        get => accountID;
        set => accountID = value;
    }

    private string accountName;
    /// <summary>
    /// This property stores user's fullname
    /// </summary>
    public string AccountName
    {
        get => accountName;
        set => accountName = value;
    }

    private string accountUserName;
    /// <summary>
    /// This property stores the username
    /// </summary>
    public string AccountUserName
    {
        get => accountUserName;
        set => accountUserName = value;
    }

    private string accountPassword;
    /// <summary>
    /// This property stores the password
    /// </summary>
    public string AccountPassword
    {
        get => accountPassword;
        set => accountPassword = value;
    }
}

