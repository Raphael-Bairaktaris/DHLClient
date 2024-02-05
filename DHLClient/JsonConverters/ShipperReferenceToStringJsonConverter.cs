// Ignore Spelling: Incoterm Measurment

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="ShipperReference"/> to <see cref="string"/>
    /// </summary>
    public class ShipperReferenceToStringJsonConverter : BaseEnumJsonConverter<ShipperReference>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipperReferenceToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ShipperReference, string> GetMapper() => DHLClientConstants.ShipperReferenceToStringMapper;

        #endregion
    }
}
