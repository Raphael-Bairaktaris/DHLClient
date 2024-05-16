namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="NetworkType"/> to <see cref="string"/>
    /// </summary>
    public class NetworkTypeToStringJsonConverter : BaseEnumJsonConverter<NetworkType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public NetworkTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<NetworkType, string> GetMapper() => DHLClientConstants.NetworkTypeToStringMapper;

        #endregion
    }
}
