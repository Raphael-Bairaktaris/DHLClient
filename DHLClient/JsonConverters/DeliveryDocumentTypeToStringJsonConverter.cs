namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="DeliveryDocumentType"/> to <see cref="string"/>
    /// </summary>
    public class DeliveryDocumentTypeToStringJsonConverter : BaseEnumJsonConverter<DeliveryDocumentType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DeliveryDocumentTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<DeliveryDocumentType, string> GetMapper() => DHLClientConstants.DeliveryDocumentTypeToStringMapper;

        #endregion
    }
}
