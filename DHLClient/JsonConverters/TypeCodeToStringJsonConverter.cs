// Ignore Spelling: Incoterm Measurment

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="BreakdownType"/> to <see cref="string"/>
    /// </summary>
    public class TypeCodeToStringJsonConverter : BaseEnumJsonConverter<BreakdownType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TypeCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<BreakdownType, string> GetMapper() => DHLClientConstants.TypeCodeToStringMapper;

        #endregion
    }
}
