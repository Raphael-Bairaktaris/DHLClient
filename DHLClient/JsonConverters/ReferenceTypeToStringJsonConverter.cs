// Ignore Spelling: Incoterm Measurment

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="ReferenceType"/> to <see cref="string"/>
    /// </summary>
    public class ReferenceTypeToStringJsonConverter : BaseEnumJsonConverter<ReferenceType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ReferenceTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ReferenceType, string> GetMapper() => DHLClientConstants.ReferenceTypeToStringMapper;

        #endregion
    }
}
