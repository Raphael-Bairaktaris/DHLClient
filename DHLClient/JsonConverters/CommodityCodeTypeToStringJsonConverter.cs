namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="CommodityCodeType"/> to <see cref="string"/>
    /// </summary>
    public class CommodityCodeTypeToStringJsonConverter : BaseEnumJsonConverter<CommodityCodeType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CommodityCodeTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<CommodityCodeType, string> GetMapper() => DHLClientConstants.CommodityCodeTypeToStringMapper;

        #endregion
    }
}
