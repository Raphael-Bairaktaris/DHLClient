using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="FileFormat"/> to <see cref="string"/>
    /// </summary>
    public class FileFormatToStringJsonConverter : BaseEnumJsonConverter<FileFormat>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public FileFormatToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<FileFormat, string> GetMapper() => DHLClientConstants.FileFormatToStringMapper;

        #endregion
    }
}
