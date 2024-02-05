namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="DocumentInvoiceType"/> to <see cref="string"/>
    /// </summary>
    public class DocumentInvoiceTypeToStringJsonConverter : BaseEnumJsonConverter<DocumentInvoiceType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DocumentInvoiceTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<DocumentInvoiceType, string> GetMapper() => DHLClientConstants.DocumentInvoiceTypeToStringMapper;

        #endregion
    }
}
