// Ignore Spelling: Incoterm Measurment

namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="ServicepointStatus"/> to <see cref="string"/>
    /// </summary>
    public class ServicePointStatusToStringJsonConverter : BaseEnumJsonConverter<ServicepointStatus>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointStatusToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ServicepointStatus, string> GetMapper() => DHLClientConstants.ServicePointStatusToStringMapper;

        #endregion
    }
}
