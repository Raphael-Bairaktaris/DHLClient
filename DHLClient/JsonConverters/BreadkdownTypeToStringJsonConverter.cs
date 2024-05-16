// Ignore Spelling: Incoterm Measurment

namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="BreakdownType"/> to <see cref="string"/>
    /// </summary>
    public class BreadkdownTypeToStringJsonConverter : BaseEnumJsonConverter<BreakdownType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BreadkdownTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<BreakdownType, string> GetMapper() => DHLClientConstants.TypeCodeToStringMapper;

        #endregion
    }
}
