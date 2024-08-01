using System;

/// <summary>
/// This class represent a service that will Log everything that happens to the system
/// The singleton patter was used in this class
/// <seealso cref="Airline.Program.SingletonPattern"/>
/// </summary>
public class LogWriter
{
    private static LogWriter _instance;

    public int SessionLogID;

    protected LogWriter()
    {
        Random r = new Random(1);
        SessionLogID = r.Next();
    }

    public static LogWriter Instance()
    {
        if (_instance == null)
        {
            _instance = new LogWriter();
        }

        return _instance;
    }

    public void LogInfomation(string info)
    {

    }
}