// Ignore Spelling: Incoterm Measurment

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="TypeCode"/> to <see cref="string"/>
    /// </summary>
    public class TypeCodeToStringJsonConverter : BaseEnumJsonConverter<TypeCode>
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
        protected override IReadOnlyDictionary<TypeCode, string> GetMapper() => DHLClientConstants.TypeCodeToStringMapper;

        #endregion
    }
}
