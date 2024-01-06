namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="ServicePointLocationType"/> to <see cref="string"/>
    /// </summary>
    public class ServicePointLocationTypeToStringJsonConverter : BaseEnumJsonConverter<ServicePointLocationType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationTypeToStringJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ServicePointLocationType, string> GetMapper() => DHLClientConstants.ServicePointLocationTypeToStringMapper;

        #endregion
    }
}