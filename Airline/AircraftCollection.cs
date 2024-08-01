using System.Collections;
using System.Collections.Generic;
/// <summary>
/// This is Iterator Design Pattern. This pattern is also represented for High Cohesion as all its methods define
/// its properties.
/// </summary>
public class AircraftCollection : IEnumerable
{
	private List<Aircraft> aircrafts;
    /// <summary>
    /// Aircrafts property represents for Aircraft generic list
    /// </summary>
    /// <value>The Aircrafts property gets/sets the value of the generic list with Aircraft type</value>
    public List<Aircraft> Aircrafts
    {
        get => aircrafts;
        set => aircrafts = value;
    }

	private AirlineBrand airlineBrand;
    /// <summary>
    /// Constructor with instantiating Aircraft generic list
    /// </summary>
    public AircraftCollection()
    {
        aircrafts = new List<Aircraft>();
    }

    /// <summary>
    /// AirlineBrand is an object represent for different brand of Airline company
    /// </summary>
    /// <example>AirCanada, AirCanada Express, AirCanada Rogue</example>
    /// <value>The AirlineBrand property gets/sets the value of the AirlineBrand type</value>
    public AirlineBrand AirlineBrand
    {
        get => airlineBrand;
        set => airlineBrand = value;
    }

    /// <summary>
    /// Method to sort the collection
    /// </summary>
    public void GetAircraftsSorted()
    {
        aircrafts.Sort();
    }

    /// <summary>
    /// Method to supply the Aircraft in AircraftCollection
    /// </summary>
    /// <returns>Return the Aircraft object</returns>
    public IEnumerator GetEnumerator()
    {
        foreach (Aircraft ac in aircrafts)
        {
            yield return ac;
        }
    }

    /// <summary>
    /// Method to add aircraft into collection
    /// </summary>
    /// <param name="aircraft">Used to indicate Aircraft object</param>
    public void Add(Aircraft aircraft)
    {
        aircrafts.Add(aircraft);
    }

    /// <summary>
    /// Method to remove aircraft into collection
    /// </summary>
    /// <param name="aircraft">Used to indicate Aircraft object</param>
    public void Remove(Aircraft aircraft)
    {
        aircrafts.Remove(aircraft);
    }
}

