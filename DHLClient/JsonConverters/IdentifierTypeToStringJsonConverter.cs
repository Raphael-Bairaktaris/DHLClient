namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="IdentifierType"/> to <see cref="string"/>
    /// </summary>
    public class IdentifierTypeToStringJsonConverter : BaseEnumJsonConverter<IdentifierType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IdentifierTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<IdentifierType, string> GetMapper() => DHLClientConstants.IdentifierTypeToStringMapper;

        #endregion
    }
}
