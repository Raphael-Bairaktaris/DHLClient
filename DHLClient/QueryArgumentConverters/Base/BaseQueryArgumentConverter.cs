namespace DHLClient
{
    /// <summary>
    /// The base for all the query argument converters
    /// </summary>
    /// <typeparam name="TValue">The type of the value</typeparam>
    public abstract class BaseQueryArgumentConverter<Tvalue> : IQueryArgumentConverter
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public string Convert(Type valueType, object value) => Convert((Tvalue)value);

        /// <summary>
        /// Converts the specified <paramref name="value"/>
        /// </summary>
        /// <param name="value">The value</param>
        /// <returns></returns>
        public abstract string Convert(Tvalue value);

        #endregion
    }
}