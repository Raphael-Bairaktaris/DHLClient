namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="CurrencyCode"/> to <see cref="string"/>
    /// </summary>
    public class CurrencyCodeToStringJsonConverter : BaseEnumJsonConverter<CurrencyCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CurrencyCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<CurrencyCode, string> GetMapper() => DHLClientConstants.CurrencyCodeToStringMapper;

        #endregion
    }
}
