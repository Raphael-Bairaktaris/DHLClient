// Ignore Spelling: Incoterm Measurment

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="ShipmentPurpose"/> to <see cref="string"/>
    /// </summary>
    public class ShipmentPurposeToStringJsonConverter : BaseEnumJsonConverter<ShipmentPurpose>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentPurposeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ShipmentPurpose, string> GetMapper() => DHLClientConstants.ShipmentPurposeToStringMapper;

        #endregion
    }
}
