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
        public DateTimeOffset PlannedShippingDatimeAndTime { get; set; }

        /// <summary>
        /// The pickup
        /// </summary>
        [JsonRequired]
        [JsonProperty("pickup")]
        public ShipmentPickupRequestModel? Pickup { get; set; }

        /// <summary>
        /// Please enter DHL Express Global Product code
        /// </summary>
        [JsonProperty("productCode")]
        [JsonRequired]
        public string ProductCode { get; set; }

        /// <summary>
        /// Please enter DHL Express Local Product code. Important when shipping domestic products.
        /// </summary>
        [JsonProperty("localProductCode")]
        public string LocalProductCode { get; set; }

        /// <summary>
        /// Please advise if you want to get rate estimates for given shipment
        /// </summary>
        [JsonProperty("getRateEstimates")]
        public bool ShouldGetRateEstimates { get; set; }

        /// <summary>
        /// Please enter all the DHL Express accounts and types to be used for this shipment
        /// </summary>
        [JsonProperty("accounts")]
        [JsonRequired]
        public IEnumerable<AccountRequestModel> Accounts { get; set; }

        /// <summary>
        /// This section communicates additional shipping services, such as Insurance (or Shipment Value Protection).
        /// </summary>
        [JsonProperty("valueAddedServices")]
        public IEnumerable<ValueAddedServiceRequestModel> ValueAddedServices { get; set; }

        /// <summary>
        /// Here you can modify label, waybillDoc, invoice and shipment receipt properties
        /// </summary>
        [JsonProperty("outputImageProperties")]
        public IEnumerable<ShipmentOutputImagePropertyRequestModel> OutputImageProperties { get; set; }

        /// <summary>
        /// Here you can declare your customer references
        /// </summary>
        [JsonProperty("customerReferences")]
        public IEnumerable<ShipmentCustomerReferenceRequestModel> CustomerReferences { get; set; }

        /// <summary>
        /// Identifiers section is on the shipment level where you can optionally provide a DHL Express waybill number. This has to be enabled by your DHL Express IT contact.
        /// </summary>
        [JsonProperty("identifiers")]
        public IEnumerable<ShipmentIdentifierRequestModel> Identifiers { get; set; }

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
