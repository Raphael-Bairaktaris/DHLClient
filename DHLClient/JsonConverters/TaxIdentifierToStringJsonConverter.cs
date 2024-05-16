namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="TaxIdentifier"/> to <see cref="string"/>
    /// </summary>
    public class TaxIdentifierToStringJsonConverter : BaseEnumJsonConverter<TaxIdentifier>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaxIdentifierToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<TaxIdentifier, string> GetMapper() => DHLClientConstants.TaxIdentifierToStringMapper;

        #endregion
    }
}
