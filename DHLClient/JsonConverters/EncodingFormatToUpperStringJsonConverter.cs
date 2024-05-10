namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="EncodingFormat"/> to upper <see cref="string"/>
    /// </summary>
    public class EncodingFormatToUpperStringJsonConverter : BaseEnumJsonConverter<EncodingFormat>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public EncodingFormatToUpperStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<EncodingFormat, string> GetMapper() => DHLClientConstants.EncodingFormatToUpperStringMapper;

        #endregion
    }
}
