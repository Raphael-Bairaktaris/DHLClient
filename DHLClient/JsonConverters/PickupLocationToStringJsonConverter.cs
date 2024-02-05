// Ignore Spelling: Incoterm Measurment

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="PickupLocation"/> to <see cref="string"/>
    /// </summary>
    public class PickupLocationToStringJsonConverter : BaseEnumJsonConverter<PickupLocation>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PickupLocationToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PickupLocation, string> GetMapper() => DHLClientConstants.PickupLocationToStringMapper;

        #endregion
    }
}
