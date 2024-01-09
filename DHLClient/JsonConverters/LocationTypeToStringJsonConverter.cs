namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="LocationType"/> to <see cref="string"/>
    /// </summary>
    public class LocationTypeToStringJsonConverter : BaseEnumJsonConverter<LocationType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LocationTypeToStringJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<LocationType, string> GetMapper() => DHLClientConstants.LocationTypeToStringMapper;

        #endregion
    }
}