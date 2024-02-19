using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="ShipmentAttribute"/> to <see cref="string"/>
    /// </summary>
    public class ShipmentAttributeToStringJsonConverter : BaseEnumJsonConverter<ShipmentAttribute>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentAttributeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ShipmentAttribute, string> GetMapper() => DHLClientConstants.ShipmentAttributeToStringMapper;

        #endregion
    }
}
