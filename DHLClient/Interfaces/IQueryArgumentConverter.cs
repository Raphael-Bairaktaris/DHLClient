namespace DHLClient
{
    /// <summary>
    /// Provides abstractions for a query argument converter
    /// </summary>
    public interface IQueryArgumentConverter
    {
        #region Methods

        /// <summary>
        /// Converts the specified <paramref name="value"/> 
        /// </summary>
        /// <param name="valueType">The type of the value.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        string Convert(Type valueType, object value);

        #endregion
    }
}
