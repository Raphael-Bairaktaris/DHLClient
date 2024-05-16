using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an item
    /// </summary>
    public class RatingItemRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Line item number
        /// </summary>
        /// <example>1</example>
        [JsonRequired]
        [JsonProperty("number")]
        public double Number { get; set; }

        /// <summary>
        /// Name of the item
        /// </summary>
        /// <example>KNITWEAR COTTON</example>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Item fill description
        /// </summary>
        /// <example>KNITWEAR 100% COTTON REDUCTION PRICE FALL COLLECTION</example>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// ISO Country code of the goods manufacturer
        /// </summary>
        /// <example>US</example>
        [JsonProperty("manufacturerCountry")]
        [JsonConverter(typeof(CountryCodeToStringJsonConverter))]
        public CountryCode ManufacturerCountry { get; set; }

        /// <summary>
        /// SKU number
        /// </summary>
        /// <example>12345555</example>
        [JsonProperty("partNumber")]
        public double PartNumber { get; set; }

        /// <summary>
        /// Total quantity of the item(s) to be shipped.
        /// </summary>
        /// <example>2</example>
        [JsonRequired]
        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        /// <summary>
        /// Please provide quantity type.
        /// </summary>
        /// <example>prt</example>
        [JsonProperty("quantityType")]
        [JsonConverter(typeof(QuantityTypeToStringJsonConverter))]
        public QuantityType QuantityType { get; set; }

        /// <summary>
        /// Product Unit price
        /// </summary>
        /// <example>2500</example>
        [JsonRequired]
        [JsonProperty("unitPrice")]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Currency code of the Unit Price
        /// </summary>
        /// <example>AUD</example>
        [JsonRequired]
        [JsonProperty("unitPriceCurrencyCode")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode UnitPriceCurrencyCode { get; set; }

        /// <summary>
        /// The commodity code
        /// </summary>
        /// <example>640391</example>
        [JsonProperty("commodityCode")]
        public string CommodityCode { get; set; }

        /// <summary>
        /// The weight of the item
        /// </summary>
        /// <example>5</example>
        [JsonProperty("weight")]
        public double Weight { get; set; }

        /// <summary>
        /// The unit of measurement
        /// </summary>
        /// <example>metric</example>
        [JsonProperty("weightUnitOfMeasurement")]
        [JsonConverter(typeof(MeasurmentUnitToStringJsonConverter))]
        public MeasurmentUnit WeightUnitOfMeasurement { get; set; }

        /// <summary>
        /// Category code of the Item
        /// </summary>
        /// <example>201</example>
        [JsonProperty("category")]
        public string? Category { get; set; }

        /// <summary>
        /// The item's brand
        /// </summary>
        /// <example>SHOE 1</example>
        [JsonProperty("brand")]
        public string? Brand { get; set; }

        /// <summary>
        /// The goods characteristics
        /// </summary>
        [JsonProperty("goodsCharacteristics")]
        public IEnumerable<GoodsCharacteristicRequestModel>? GoodsCharacteristics { get; set; }

        /// <summary>
        /// The additional quantity definitions
        /// </summary>
        public IEnumerable<AdditionalQuantityDefinitionRequestModel>? AdditionalQuantityDefinitions { get; set; }

        /// <summary>
        /// Please enter Tariff Rate Type
        /// </summary>
        [JsonProperty("estimatedTariffRateType")]
        [JsonConverter(typeof(EstimatedTariffRateToStringJsonConverter))]
        public EstimatedTariffRate EstimatedTariffRateType { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RatingItemRequestModel() : base()
        {

        }

        #endregion
    }
}