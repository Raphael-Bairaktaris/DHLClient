namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="ShipmentServiceType"/> to <see cref="string"/>
    /// </summary>
    public class ShipmentServiceTypeToStringJsonConverter : BaseEnumJsonConverter<ShipmentServiceType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentServiceTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ShipmentServiceType, string> GetMapper() => DHLClientConstants.ShipmentServiceTypeToStringMapper;

        #endregion
    }
}
