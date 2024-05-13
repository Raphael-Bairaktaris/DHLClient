namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="ImageFormat"/> to <see cref="string"/>
    /// </summary>
    public class ImageFormatToLowerStringJsonConverter : BaseEnumJsonConverter<ImageFormat>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ImageFormatToLowerStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ImageFormat, string> GetMapper() => DHLClientConstants.ImageFormatToLowerStringMapper;

        #endregion
    }
}
