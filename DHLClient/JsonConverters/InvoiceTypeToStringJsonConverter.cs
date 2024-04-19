namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseEnumJsonConverter{T}"/> that is used for converting an <see cref="InvoiceType"/> to <see cref="string"/>
    /// </summary>
    public class InvoiceTypeToStringJsonConverter : BaseEnumJsonConverter<InvoiceType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<InvoiceType, string> GetMapper() => DHLClientConstants.InvoiceTypeToStringMapper;

        #endregion
    }
}
