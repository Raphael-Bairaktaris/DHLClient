namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a  <see cref="ServiceType"/> to <see cref="string"/>
    /// </summary>
    public class ServiceTypeToStringJsonConverter : BaseEnumJsonConverter<ServiceType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServiceTypeToStringJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ServiceType, string> GetMapper() => DHLClientConstants.ServiceTypeToStringMapper;

        #endregion
    }
}