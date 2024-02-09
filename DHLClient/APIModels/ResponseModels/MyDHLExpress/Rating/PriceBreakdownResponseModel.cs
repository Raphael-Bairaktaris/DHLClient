using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a price breakdown response
    /// </summary>
    public class PriceBreakdownResponseModel
    {
        #region Public Properties

        /// <summary>
        /// If a breakdown is provided, details can either be; 'TAX',<BR> 'DISCOUNT'
        /// </summary>
        [JsonProperty("priceType")]
        [JsonConverter(typeof(PriceTypeToStringJsonConverter))]
        public PriceType PriceType { get; set; }

        /// <summary>
        /// Discount or tax type codes as provided by DHL Express.
        /// </summary>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(DiscountTypeToStringJsonConverter))]
        public DiscountType TypeCode { get; set; }

        /// <summary>
        /// The actual amount of the discount/tax
        /// </summary>
        [JsonProperty("number")]
        public double Number { get; set; }

        /// <summary>
        /// Percentage of the discount/tax
        /// </summary>
        [JsonProperty("rate")]
        public double Rate { get; set; }

        /// <summary>
        /// The base amount of the service charge
        /// </summary>
        [JsonProperty("basePrice")]
        public decimal BasePrice { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PriceBreakdownResponseModel() : base()
        {

        }

        #endregion
    }
}