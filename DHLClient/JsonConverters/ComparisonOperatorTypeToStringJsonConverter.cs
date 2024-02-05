namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="ComparisonOperatorType"/> to <see cref="string"/>
    /// </summary>
    public class ComparisonOperatorTypeToStringJsonConverter : BaseEnumJsonConverter<ComparisonOperatorType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ComparisonOperatorTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ComparisonOperatorType, string> GetMapper() => DHLClientConstants.ComparisonOperatorTypeToStringMapper;

        #endregion
    }
}
