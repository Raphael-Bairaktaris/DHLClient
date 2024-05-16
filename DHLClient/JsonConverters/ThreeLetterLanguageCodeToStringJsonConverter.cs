namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="ThreeLetterLanguageCode"/> to <see cref="string"/>
    /// </summary>
    public class ThreeLetterLanguageCodeToStringJsonConverter : BaseEnumJsonConverter<ThreeLetterLanguageCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ThreeLetterLanguageCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ThreeLetterLanguageCode, string> GetMapper() => DHLClientConstants.ThreeLetterLanguageCodeToStringMapper;

        #endregion
    }
}
