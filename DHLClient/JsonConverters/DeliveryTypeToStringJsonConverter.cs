namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="DeliveryType"/> to <see cref="string"/>
    /// </summary>
    public class DeliveryTypeToStringJsonConverter : BaseEnumJsonConverter<DeliveryType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DeliveryTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<DeliveryType, string> GetMapper() => DHLClientConstants.DeliveryTypeToStringMapper;

        #endregion
    }
}
