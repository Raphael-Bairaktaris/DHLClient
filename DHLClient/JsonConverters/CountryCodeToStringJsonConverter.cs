namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="CountryCode"/> to <see cref="string"/>
    /// </summary>
    public class CountryCodeToStringJsonConverter : BaseEnumJsonConverter<CountryCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CountryCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<CountryCode, string> GetMapper() => DHLClientConstants.CountryCodeToStringMapper;

        #endregion
    }
}
