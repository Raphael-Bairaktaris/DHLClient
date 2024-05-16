namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="ServicePoint"/> to <see cref="string"/>
    /// </summary>
    public class ServicePointToStringJsonConverter : BaseEnumJsonConverter<ServicePoint>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ServicePoint, string> GetMapper() => DHLClientConstants.ServicePointToStringMapper;

        #endregion
    }
}
