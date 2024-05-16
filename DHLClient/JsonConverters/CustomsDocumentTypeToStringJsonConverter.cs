namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="CustomsDocumentType"/> to <see cref="string"/>
    /// </summary>
    public class CustomsDocumentTypeToStringJsonConverter : BaseEnumJsonConverter<CustomsDocumentType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CustomsDocumentTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<CustomsDocumentType, string> GetMapper() => DHLClientConstants.CustomsDocumentTypeToStringMapper;

        #endregion
    }
}
