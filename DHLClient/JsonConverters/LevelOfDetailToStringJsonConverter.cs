// Ignore Spelling: Incoterm

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="LevelOfDetail"/> to <see cref="string"/>
    /// </summary>
    public class LevelOfDetailToStringJsonConverter : BaseEnumJsonConverter<LevelOfDetail>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LevelOfDetailToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<LevelOfDetail, string> GetMapper() => DHLClientConstants.LevelOfDetailToStringMapper;

        #endregion
    }
}
