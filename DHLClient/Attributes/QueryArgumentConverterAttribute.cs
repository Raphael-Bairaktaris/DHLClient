namespace DHLClient
{
    /// <summary>
    /// Attribute that is used for specifying query argument converter meta data.
    /// </summary>
    public class QueryArgumentConverterAttribute : Attribute
    {
        #region Public Properties

        /// <summary>
        /// The type of the converter
        /// </summary>
        public Type ConverterType { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="converterType">The type of the converter</param>
        private protected QueryArgumentConverterAttribute(Type converterType) : base()
        {
            ConverterType = converterType ?? throw new ArgumentNullException(nameof(converterType));
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates and returns a converter.
        /// </summary>
        /// <returns></returns>
        public IQueryArgumentConverter CreateConverter() => (IQueryArgumentConverter)Activator.CreateInstance(ConverterType)!;

        #endregion
    }

    /// <summary>
    /// Attribute that is used for specifying query argument converter meta data.
    /// </summary>
    /// <typeparam name="T">The type of the converter.</typeparam>
    public class QueryArgumentConverterAttribute<T> : QueryArgumentConverterAttribute
        where T : IQueryArgumentConverter, new()
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public QueryArgumentConverterAttribute() : base(typeof(T))
        {

        }

        #endregion
    }
}
