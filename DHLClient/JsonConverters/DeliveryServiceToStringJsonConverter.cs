namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="DeliveryService"/> to <see cref="string"/>
    /// </summary>
    public class DeliveryServiceToStringJsonConverter : BaseEnumJsonConverter<DeliveryService>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DeliveryServiceToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<DeliveryService, string> GetMapper() => DHLClientConstants.DeliveryServiceToStringMapper;

        #endregion
    }
}
