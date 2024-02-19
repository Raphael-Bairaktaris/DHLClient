namespace DHLClient
{
    /// <summary>
    /// A <see cref="QueryArgumentConverterAttribute{T}"/> that is used to convert a <see cref="DocumentInvoiceType"/> to <see cref="string"/>
    /// </summary>
    public class DocumentInvoiceTypeQueryArgumentConverter : BaseQueryArgumentConverter<DocumentInvoiceType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DocumentInvoiceTypeQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(DocumentInvoiceType value) => DHLClientConstants.DocumentInvoiceTypeToStringMapper[value];

        #endregion
    }
}
