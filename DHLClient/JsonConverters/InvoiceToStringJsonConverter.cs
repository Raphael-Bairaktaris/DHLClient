// Ignore Spelling: Incoterm

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="Invoice"/> to <see cref="string"/>
    /// </summary>
    public class InvoiceToStringJsonConverter : BaseEnumJsonConverter<Invoice>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<Invoice, string> GetMapper() => DHLClientConstants.InvoiceToStringMapper;

        #endregion
    }
}
