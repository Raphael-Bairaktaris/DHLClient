// Ignore Spelling: Incoterm

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="LineItemReferenceType"/> to <see cref="string"/>
    /// </summary>
    public class LineItemReferenceTypeToStringJsonConverter : BaseEnumJsonConverter<LineItemReferenceType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LineItemReferenceTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<LineItemReferenceType, string> GetMapper() => DHLClientConstants.LineItemReferenceTypeToStringMapper;

        #endregion
    }
}
