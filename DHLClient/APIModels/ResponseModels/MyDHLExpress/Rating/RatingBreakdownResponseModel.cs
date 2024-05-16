using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a price breakdown
    /// </summary>
    public class RatingBreakdownResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="TypeCode"/> property
        /// </summary>
        private string? mTypeCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// If a breakdown is provided, details can either be; 'TAX', 'DISCOUNT'
        /// </summary>
        [JsonProperty("priceType")]
        [JsonConverter(typeof(PriceTypeToStringJsonConverter))]
        public PriceType PriceType { get; set; }

        /// <summary>
        /// Discount or tax type codes as provided by DHL Express.
        /// </summary>
        [JsonProperty("typeCode")]
        public string TypeCode
        {
            get => mTypeCode ?? string.Empty;
            set => mTypeCode = value;
        }

        /// <summary>
        /// The actual amount of the discount/tax
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }

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
        public RatingBreakdownResponseModel() : base()
        {

        }

        #endregion
    }
}