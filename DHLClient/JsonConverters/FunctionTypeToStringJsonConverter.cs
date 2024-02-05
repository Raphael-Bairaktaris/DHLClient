namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="FunctionType"/> to <see cref="string"/>
    /// </summary>
    public class FunctionTypeToStringJsonConverter : BaseEnumJsonConverter<FunctionType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public FunctionTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<FunctionType, string> GetMapper() => DHLClientConstants.FunctionTypeToStringMapper;

        #endregion
    }
}
