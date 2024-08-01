using System;
using System.Collections.Generic;

/// <summary>
/// Class Search By TimeFrame derived from interface Search Strategy
/// </summary>
public class SearchByTimeFrame : SearchStrategy
{
    /// <summary>
    /// Return the Search Result with TimeFrame condition
    /// </summary>
    public override void SearchMethod()
    {
        Console.WriteLine("Search result by TimeFrame");
    }
}