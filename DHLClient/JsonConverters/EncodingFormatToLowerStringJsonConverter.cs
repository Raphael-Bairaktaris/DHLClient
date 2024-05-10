namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="EncodingFormat"/> to lower <see cref="string"/>
    /// </summary>
    public class EncodingFormatToLowerStringJsonConverter : BaseEnumJsonConverter<EncodingFormat>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public EncodingFormatToLowerStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<EncodingFormat, string> GetMapper() => DHLClientConstants.EncodingFormatToLowerStringMapper;

        #endregion
    }
}
