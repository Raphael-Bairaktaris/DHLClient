using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents an item price breakdown
    /// </summary>
    public class ItemPriceBreakdownResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Discount or tax type codes as provided by DHL
        /// </summary>
        [JsonProperty("priceType")]
        [JsonConverter(typeof(DiscountTypeToStringJsonConverter))]
        public DiscountType PriceType { get; set; }

        /// <summary>
        /// If a breakdown is provided, details can either be
        /// </summary>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(ChargeCategoryToStringJsonConverter))]
        public ChargeCategory TypeCode { get; set; }

        /// <summary>
        /// The actual amount of the discount/tax
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Percentage of the discount/tax
        /// </summary>
        [JsonProperty("rate")]
        public decimal Rate { get; set; }

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
        public ItemPriceBreakdownResponseModel() : base()
        {

        }

        #endregion
    }
}