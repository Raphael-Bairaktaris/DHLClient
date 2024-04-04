using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a shipment
    /// </summary>
    public class CreateShipmentRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Identifies the date and time the package is tendered. Both the date and time portions of the string are expected to be used. The date should not be a past date or a
        /// date more than 10 days in the future. The time is the local time of the shipment based on the shipper's time zone. The date component must be in the format: YYYY-MM-DD; 
        /// the time component must be in the format: HH:MM:SS using a 24 hour clock. The date and time parts are separated by the letter T
        /// </summary>
        /// <example>2006-06-26T17:00:00 GMT+01:00</example>
        [JsonRequired]
        [JsonProperty("plannedShippingDateAndTime")]
        [JsonConverter(typeof(DateTimeOffsetWithGMTPrefixToStringJsonConverter))]
        public DateTimeOffset? PlannedShippingDatimeAndTime { get; set; }

        /// <summary>
        /// The shipment pickup 
        /// </summary>
        [JsonRequired]
        [JsonProperty("pickup")]
        public ShipmentPickupRequestModel? Pickup { get; set; }

        /// <summary>
        /// Please enter DHL Express Global Product code
        /// </summary>
        [JsonRequired]
        [JsonProperty("productCode")]
        public string? ProductCode { get; set; }

        /// <summary>
        /// Please enter DHL Express Local Product code. Important when shipping domestic products.
        /// </summary>
        [JsonProperty("localProductCode")]
        public string? LocalProductCode { get; set; }

        /// <summary>
        /// Please advise if you want to get rate estimates for given shipment
        /// </summary>
        [JsonProperty("getRateEstimates")]
        public bool? ShouldGetRateEstimates { get; set; }

        /// <summary>
        /// Please enter all the DHL Express accounts and types to be used for this shipment
        /// </summary>
        [JsonProperty("accounts")]
        [JsonRequired]
        public IEnumerable<AccountRequestModel>? Accounts { get; set; }

        /// <summary>
        /// This section communicates additional shipping services, such as Insurance (or Shipment Value Protection).
        /// </summary>
        [JsonProperty("valueAddedServices")]
        public IEnumerable<ValueAddedServiceRequestModel>? ValueAddedServices { get; set; }

        /// <summary>
        /// Here you can modify label, waybillDoc, invoice and shipment receipt properties
        /// </summary>
        [JsonProperty("outputImageProperties")]
        public ShipmentOutputImagePropertyRequestModel? OutputImageProperties { get; set; }

        /// <summary>
        /// Here you can declare your customer references
        /// </summary>
        [JsonProperty("customerReferences")]
        public IEnumerable<ShipmentCustomerReferenceRequestModel>? CustomerReferences { get; set; }

        /// <summary>
        /// Identifiers section is on the shipment level where you can optionally provide a DHL Express waybill number. This has to be enabled by your DHL Express IT contact.
        /// </summary>
        [JsonProperty("identifiers")]
        public IEnumerable<ShipmentIdentifierRequestModel>? Identifiers { get; set; }

        /// <summary>
        /// Here you need to define all the parties needed to ship the package
        /// </summary>
        [JsonRequired]
        [JsonProperty("customerDetails")]
        public ShipmentCustomerDetailRequestModel? CustomerDetails { get; set; }

        /// <summary>
        /// Here you can define all the properties related to the content of the prospected shipment
        /// </summary>
        [JsonRequired]
        [JsonProperty("content")]
        public ShipmentDetailContentRequestModel? Content { get; set; }

        /// <summary>
        /// This section is to support multiple base64 encoded string with the image of export documentation for Paperless Trade images. 
        /// When an invalid base64 encoded string is provided, an error message will be returned
        /// </summary>
        [JsonProperty("documentImages")]
        public IEnumerable<ShipmentDetailDocumentImageRequestModel>? DocumentImages { get; set; }

        /// <summary>
        /// Here you can provide data in case you wish to use DHL Express On demand delivery service
        /// </summary>
        [JsonProperty("onDemandDelivery")]
        public ShipmentDetailOnDemandDeliveryRequestModel? OnDemandDelivery { get; set; }

        /// <summary>
        /// Determines whether to request the On Demand Delivery (ODD) link. When set to true it will provide an URL link for the specified Waybill Value, 
        /// Shipper Account Value. The default value is false, no ODD link URL is provided in the response message.
        /// </summary>
        [JsonProperty("requestOndemandDeliveryURL")]
        public bool ShouldGetRequestOnDemandDeliveryURL { get; set; }

        /// <summary>
        /// This is to support sending email notification once the shipment is created. 
        /// The email will contain the basic information on the shipper, recipient, waybill number, and shipment information
        /// </summary>
        [JsonProperty("shipmentNotification")]
        public IEnumerable<ShipmentNotificationDetailRequestModel>? ShipmentNotification { get; set; }

        /// <summary>
        /// Please provide any charges you have already paid for this shipment, like freight paid upfront. 
        /// To allow using this section please contact your DHL Express representative
        /// </summary>
        public IEnumerable<ShipmentDetailPrepaidChargeRequestModel>? PrepaidCharges { get; set; }

        /// <summary>
        /// If set to true, response will return transliterated text of shipper and receiver details.
        /// </summary>
        [JsonProperty("getTransliteratedResponse")]
        public bool ShouldGetTansliteratedResponse { get; set; }

        /// <summary>
        /// Estimated delivery date option for QDDF or QDDC.
        /// </summary>
        [JsonProperty("estimatedDeliveryDate")]
        public ShipmentDetailEstimatedDeliveryDateRequestModel? EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Provides additional information in the response like service area details, routing code and pickup-related information
        /// </summary>
        [JsonProperty("getAdditionalInformation")]
        public IEnumerable<ShipmentDetailGetAdditionalInformationRequestModel>? GetAdditionalInformation { get; set; }

        /// <summary>
        /// Please provide the parent (mother) shipment details
        /// </summary>
        [JsonProperty("parentShipment")]
        public ShipmentDetailParentShipmentRequestModel? ParentShipment { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CreateShipmentRequestModel() : base()
        {

        }

        #endregion
    }
}
