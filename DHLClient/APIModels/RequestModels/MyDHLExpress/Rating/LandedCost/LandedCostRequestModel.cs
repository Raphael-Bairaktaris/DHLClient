﻿using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a rating landed cost
    /// </summary>
    public class LandedCostRequestModel : BaseRatingRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter Unit of measurement
        /// </summary>
        [JsonRequired]
        [JsonProperty("unitOfMeasurement")]
        [JsonConverter(typeof(MeasurementUnitToStringJsonConverter))]
        public MeasurmentUnit? UnitOfMeasurement { get; set; }

        /// <summary>
        /// Currency code for the item price (the product being sold) and freight charge. The Landed Cost calculation result will be returned in this defined currency
        /// </summary>
        [JsonRequired]
        [JsonProperty("currencyCode")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode? CurrencyCode { get; set; }

        /// <summary>
        /// Set this to true is shipment contains declarable content
        /// </summary>
        [JsonRequired]
        [JsonProperty("isCustomsDeclarable")]
        public bool IsCustomsDeclarable { get; set; }

        /// <summary>
        /// Set this to true if you want DHL EXpress product Duties and Taxes Paid outside shipment destination
        /// </summary>
        [JsonProperty("isDTPRequested")]
        public bool IsDTPRequested { get; set; }

        /// <summary>
        /// Set this true if you ask for DHL Express insurance service
        /// </summary>
        [JsonProperty("isInsuranceRequested")]
        public bool IsInsuranceRequested { get; set; }

        /// <summary>
        /// Allowed values 'true' - item cost breakdown will be returned, 'false' - item cost breakdown will not be returned
        /// </summary>
        [JsonRequired]
        [JsonProperty("getCostBreakdown")]
        public bool ShouldGetCostBreakdown { get; set; }

        /// <summary>
        /// Please provide any additional charges you would like to include in total cost calculation
        /// </summary>
        [JsonProperty("charges")]
        public IEnumerable<ChargesRequestModel>? Charges { get; set; }

        /// <summary>
        /// The shipment purpose
        /// </summary>
        [JsonProperty("shipmentPurpose")]
        [JsonConverter(typeof(ShipmentPurposeToStringJsonConverter))]
        public ShipmentPurpose? ShipmentPurpose { get; set; }

        /// <summary>
        /// The type of transportation
        /// </summary>
        [JsonProperty("transoportationMode")]
        [JsonConverter(typeof(TransportationModeToStringJsonConverter))]
        public TransportationMode? TransportationMode { get; set; }

        /// <summary>
        /// Carrier being used to ship with.
        /// </summary>
        [JsonProperty("merchantSelectedCarrierName")]
        [JsonConverter(typeof(CarrierNameToStringJsonConverter))]
        public CarrierName? MerchantSelectedCarrierName { get; set; }

        /// <summary>
        /// The items
        /// </summary>
        [JsonRequired]
        [JsonProperty("items")]
        public IEnumerable<RatingItemRequestModel>? Items { get; set; }

        /// <summary>
        /// Allowed values 'true' - tariff formula on item and shipment level will be returned, 'false' - tariff formula on item and shipment level will not be returned
        /// </summary>
        [JsonProperty("getTariffFormula")]
        public bool ShouldGetTariffFormula { get; set; }

        /// <summary>
        /// Allowed values 'true' - quotation ID on shipment level will be returned, 'false' - quotation ID on shipment level will not be returned
        /// </summary>
        [JsonProperty("getQuotationID")]
        public bool ShouldGetQuotation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LandedCostRequestModel() : base()
        {

        }

        #endregion
    }
}
