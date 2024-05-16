namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="QuantityType"/> to <see cref="string"/>
    /// </summary>
    public class QuantityTypeToStringJsonConverter : BaseEnumJsonConverter<QuantityType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public QuantityTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<QuantityType, string> GetMapper() => DHLClientConstants.QuantityTypeToStringMapper;

        #endregion
    }
}
