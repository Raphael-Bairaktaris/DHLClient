namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="CountryDivisionCode"/> to <see cref="string"/>
    /// </summary>
    public class CountryDivisionCodeToStringJsonConverter : BaseEnumJsonConverter<CountryDivisionCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CountryDivisionCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<CountryDivisionCode, string> GetMapper() => DHLClientConstants.CountryDivisionCodeToStringMapper;

        #endregion
    }
}
