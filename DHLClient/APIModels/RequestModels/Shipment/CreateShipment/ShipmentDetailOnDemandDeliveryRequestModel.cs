using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an on demand delivery
    /// </summary>
    public class ShipmentDetailOnDemandDeliveryRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please choose from one of the delivery options
        /// </summary>
        [JsonProperty("deliveryOption")]
        [JsonConverter(typeof(DeliveryOptionToStringJsonConverter))]
        public DeliveryOption? DeliveryOption { get; set; }

        /// <summary>
        /// If delivery option is signatureDelivery please specify location where to leave the shipment
        /// </summary>
        /// <example>Front Door</example>
        [JsonProperty("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Please enter additional information that might be useful for the DHL Express courier
        /// </summary>
        /// <example>Ring twice</example>
        [JsonProperty("specialInstructions")]
        public string? SpecialInstructions { get; set; }

        /// <summary>
        /// Please provide entry code to gain access to an apartment complex or gate
        /// </summary>
        [JsonProperty("gateCode")]
        public string? GateCode { get; set; }

        /// <summary>
        /// In as your deliveryOption is 'neighbour' please specify where to leave the package
        /// </summary>
        [JsonProperty("whereToLeave")]
        [JsonConverter(typeof(DeliveryOptionToStringJsonConverter))]
        public DeliveryOption? WhereToLeave { get; set; }

        /// <summary>
        /// In case you wish to leave the package with neighbour please provide the neighbour's name
        /// </summary>
        /// <example>Mr.Dan</example>
        [JsonProperty("neighbourName")]
        public string? NeighbourName { get; set; }

        /// <summary>
        /// In case you wish to leave the package with neighbour please provide the neighbour's house number
        /// </summary>
        [JsonProperty("neighbourHouseNumber")]
        public int? NeighbourHouseNumber { get; set; }

        /// <summary>
        /// In case your delivery option is 'signatureRelease' please provide name of the person who is authorized to sign and receive the package
        /// </summary>
        /// <example>Newman</example>
        [JsonProperty("authorizerName")]
        public string? AuthorizerName { get; set; }

        /// <summary>
        /// In case your delivery option is 'servicepoint' please provide unique DHL Express Service point location ID of 
        /// where the parcel should be delivered (please contact your local DHL Express Account Manager to obtain the list of the servicepoint IDs)
        /// </summary>
        /// <example>SPL123</example>
        [JsonProperty("servicePointId")]
        public string? ServicePointId { get; set; }

        /// <summary>
        /// For future use
        /// </summary>
        /// <example>2020-04-20</example>
        [JsonProperty("requestDeliveryDate")]
        public DateOnly? RequestDeliveryDate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailOnDemandDeliveryRequestModel() : base()
        {

        }

        #endregion
    }
}