namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/>that is used to convert <see cref="InvoiceCustomerReference"/> to <see cref="string"/>
    /// </summary>
    public class InvoiceCustomerReferenceToStringJsonConverter : BaseEnumJsonConverter<InvoiceCustomerReference>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceCustomerReferenceToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<InvoiceCustomerReference, string> GetMapper() => DHLClientConstants.InvoiceCustomerReferenceToStringMapper;

        #endregion
    }
}
