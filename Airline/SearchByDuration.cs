using System;
using System.Collections.Generic;
/// <summary>
/// Class Search by Duration derived from interface Search Strategy
/// </summary>
public class SearchByDuration : SearchStrategy
{
    /// <summary>
    /// Return the search result with duration condition
    /// </summary>
    public override void SearchMethod()
    {
        Console.WriteLine("Search result by duration");
    }
}

