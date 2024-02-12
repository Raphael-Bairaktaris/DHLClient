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
        [JsonRequired]
        [JsonProperty("number")]
        public double Number { get; set; }

        /// <summary>
        /// Name of the item
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Item fill description
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// ISO Country code of the goods manufacturer
        /// </summary>
        [JsonProperty("manufacturerCountry")]
        [JsonConverter(typeof(CountryCodeToStringJsonConverter))]
        public CountryCode ManufacturerCountry { get; set; }

        /// <summary>
        /// SKU number
        /// </summary>
        [JsonProperty("partNumber")]
        public double PartNumber { get; set; }

        /// <summary>
        /// Total quantity of the item(s) to be shipped.
        /// </summary>
        [JsonRequired]
        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        /// <summary>
        /// Please provide quantity type.
        /// </summary>
        [JsonProperty("quantityType")]
        [JsonConverter(typeof(QuantityTypeToStringJsonConverter))]
        public QuantityType QuantityType { get; set; }

        /// <summary>
        /// Product Unit price
        /// </summary>
        [JsonRequired]
        [JsonProperty("unitPrice")]
        public double UnitPrice { get; set; }

        /// <summary>
        /// Currency code of the Unit Price
        /// </summary>
        [JsonRequired]
        [JsonProperty("unitPriceCurrencyCode")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode UnitPriceCurrencyCode { get; set; }

        /// <summary>
        /// The commodity code
        /// </summary>
        [JsonProperty("commodityCode")]
        [JsonConverter(typeof(CommodityCodeToStringJsonConverter))]
        public CommodityCode CommodityCode { get; set; }

        /// <summary>
        /// The weight of the item
        /// </summary>
        [JsonProperty("weight")]
        public double Weight { get; set; }

        /// <summary>
        /// The unit of measurement
        /// </summary>
        [JsonProperty("weightUnitOfMeasurement")]
        [JsonConverter(typeof(MeasurmentUnitToStringJsonConverter))]
        public MeasurmentUnit WeightUnitOfMeasurement { get; set; }

        /// <summary>
        /// Category code of the Item
        /// </summary>
        [JsonProperty("category")]
        public string? Category { get; set; }

        /// <summary>
        /// The item's brand
        /// </summary>
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