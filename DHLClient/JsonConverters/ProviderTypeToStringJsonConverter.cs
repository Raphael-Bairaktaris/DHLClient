namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="IEnumerable{ProviderType}"/> to <see cref="string"/>
    /// </summary>
    public class ProviderTypeToStringJsonConverter : BaseEnumJsonConverter<ProviderType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProviderTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ProviderType, string> GetMapper() => DHLClientConstants.ProviderTypeToStringMapper;

        #endregion
    }
}
