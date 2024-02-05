namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="ImageFormat"/> to <see cref="string"/>
    /// </summary>
    public class ImageFormatToStringJsonConverter : BaseEnumJsonConverter<ImageFormat>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ImageFormatToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ImageFormat, string> GetMapper() => DHLClientConstants.ImageFormatToStringMapper;

        #endregion
    }
}
