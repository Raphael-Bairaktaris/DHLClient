namespace DHLClient
{
    /// <summary>
    /// Provides abstractions for an object that can be formatted to a string suitable to be placed in a URL.
    /// </summary>
    public interface IAPIStringFormattable
    {
        /// <summary>
        /// Returns a string suitable to be placed in a URL.
        /// </summary>
        /// <returns></returns>
        string ToAPIString();
    }
}

