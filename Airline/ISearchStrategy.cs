using System.Collections.Generic;
/// <summary>
/// Interface for Search Strategy with SearchMethod
/// </summary>
public interface ISearchStrategy
{
    /// <summary>
    /// Interface Search Method
    /// </summary>
    void SearchMethod();
}

/// <summary>
/// Abstract class derived from interface Search Strategy
/// </summary>
public abstract class SearchStrategy : ISearchStrategy
{
    /// <summary>
    /// Abstract method to call the Search Strategy accordingly
    /// </summary>
    public abstract void SearchMethod();
}

