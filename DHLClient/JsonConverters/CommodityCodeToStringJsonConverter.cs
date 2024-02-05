namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="CommodityCode"/> to <see cref="string"/>
    /// </summary>
    public class CommodityCodeToStringJsonConverter : BaseEnumJsonConverter<CommodityCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CommodityCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<CommodityCode, string> GetMapper() => DHLClientConstants.CommodityCodeToStringMapper;

        #endregion
    }
}
