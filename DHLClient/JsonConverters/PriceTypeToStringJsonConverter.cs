using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="ChargeType"/> to <see cref="string"/>
    /// </summary>
    public class PriceTypeToStringJsonConverter : BaseEnumJsonConverter<PriceType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PriceTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PriceType, string> GetMapper() => DHLClientConstants.PriceTypeToStringMapper;

        #endregion
    }
}
