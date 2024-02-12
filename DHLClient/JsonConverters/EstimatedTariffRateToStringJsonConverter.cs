using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts an <see cref="EstimatedTariffRate"/> to <see cref="string"/>
    /// </summary>
    public class EstimatedTariffRateToStringJsonConverter : BaseEnumJsonConverter<EstimatedTariffRate>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public EstimatedTariffRateToStringJsonConverter() : base()
        {

        }

        #endregion

        #region protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<EstimatedTariffRate, string> GetMapper() => DHLClientConstants.EstimatedTariffRateToStringMapper;

        #endregion
    }
}
