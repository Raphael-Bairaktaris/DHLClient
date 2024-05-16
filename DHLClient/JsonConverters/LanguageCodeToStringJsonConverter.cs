namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="LanguageCode"/> to <see cref="string"/>
    /// </summary>
    public class LanguageCodeToStringJsonConverter : BaseEnumJsonConverter<LanguageCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LanguageCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<LanguageCode, string> GetMapper() => DHLClientConstants.LanguageCodeToStringMapper;

        #endregion
    }
}
