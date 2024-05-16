namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="MonetaryAmountType"/> to <see cref="string"/>
    /// </summary>
    public class MonetaryAmountValueToStringJsonConverter : BaseEnumJsonConverter<MonetaryAmountType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MonetaryAmountValueToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<MonetaryAmountType, string> GetMapper() => DHLClientConstants.MonetaryAmountTypeToStringMapper;

        #endregion
    }
}
