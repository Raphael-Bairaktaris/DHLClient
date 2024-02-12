namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="ServiceType"/> to <see cref="srting"/>
    /// </summary>
    public class ServiceTypeEnumEnumerableToStringJsonConverter : BaseEnumEnumerableJsonConverter<ServiceType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServiceTypeEnumEnumerableToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ServiceType, string> GetMapper() => DHLClientConstants.ServiceTypeToStringMapper;

        #endregion
    }
}
