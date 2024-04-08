namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that is used to convert a <see cref="MonetaryAmountType"/> to <see cref="string"/>
    /// </summary>
    public class MonetaryAmountTypeToStringJsonConverter : BaseEnumJsonConverter<MonetaryAmountType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MonetaryAmountTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<MonetaryAmountType, string> GetMapper() => DHLClientConstants.MonetaryAmountTypeToStringMapper;

        #endregion
    }
}
