namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="DocumentType"/> to <see cref="string"/>
    /// </summary>
    public class DocumentTypeToStringJsonConverter : BaseEnumJsonConverter<DocumentType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DocumentTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<DocumentType, string> GetMapper() => DHLClientConstants.DocumentTypeToStringMapper;

        #endregion
    }
}
