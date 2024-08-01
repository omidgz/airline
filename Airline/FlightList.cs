using System.Collections.Generic;
/// <summary>
/// This class represents FlightList type.
/// </summary>
public class FlightList
{
	private List<Flight> flights;
    /// <summary>
    /// Flights stores a list of Flight type.
    /// </summary>
    /// <value>Flights gets/sets flights's values of List<Flight> type.</value>
    public List<Flight> Flights
    {
        get => flights;
        set => flights = value;
    }    

    private ISearchStrategy searchStrategy;
    /// <summary>
    /// SearchStrategy stores a FlightList's search strategy.
    /// </summary>
    /// <value>SearchStrategy gets/sets searchStrategy's values of ISearchStrategy interface type.</value>
    public ISearchStrategy SearchStrategy
    {
        get => searchStrategy;
        set => searchStrategy = value;
    }
    /// <summary>
    /// This method initiates search strategy of flight list.
    /// </summary>
    public void SetSearchStrategy(ISearchStrategy strategy)
	{
        this.searchStrategy = strategy;
	}

    public void Add(Flight flight)
    {
        this.Add(flight);
    }

    public void SearchMethod()
    {
        searchStrategy.SearchMethod();
    }
}

