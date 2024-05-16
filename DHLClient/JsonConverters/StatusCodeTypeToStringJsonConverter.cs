namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="StatusCodeType"/> to <see cref="string"/>
    /// </summary>
    public class StatusCodeTypeToStringJsonConverter : BaseEnumJsonConverter<StatusCodeType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public StatusCodeTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<StatusCodeType, string> GetMapper() => DHLClientConstants.StatusCodeTypeToStringMapper;

        #endregion
    }
}
