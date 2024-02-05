// Ignore Spelling: Incoterm Measurment

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="ServicePointStatus"/> to <see cref="string"/>
    /// </summary>
    public class ServicePointStatusToStringJsonConverter : BaseEnumJsonConverter<ServicePointStatus>
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
        protected override IReadOnlyDictionary<ServicePointStatus, string> GetMapper() => DHLClientConstants.ServicePointStatusToStringMapper;

        #endregion
    }
}
