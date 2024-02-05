namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="ContentType"/> to <see cref="string"/>
    /// </summary>
    public class ContentTypeToStringToJsonConverter : BaseEnumJsonConverter<ContentType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ContentTypeToStringToJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ContentType, string> GetMapper() => DHLClientConstants.ContentTypeToStringMapper;

        #endregion
    }
}
