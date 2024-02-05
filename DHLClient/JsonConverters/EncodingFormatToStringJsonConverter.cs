namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="EncodingFormat"/> to <see cref="string"/>
    /// </summary>
    public class EncodingFormatToStringJsonConverter : BaseEnumJsonConverter<EncodingFormat>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public EncodingFormatToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<EncodingFormat, string> GetMapper() => DHLClientConstants.EncodingFormatToStringMapper;

        #endregion
    }
}
