using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// The base for all entity profiles
    /// </summary>
    public class EntityProfileRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The shipper details
        /// </summary>
        [JsonProperty("shipperDetails")]
        public ShipmentPickupDetailRequestModel? ShipperDetails { get; set; }

        /// <summary>
        /// The receiver details
        /// </summary>
        [JsonProperty("receiverDetails")]
        public ShipmentPickupDetailRequestModel? ReceiverDetails { get; set; }

        /// <summary>
        /// The buyer details
        /// </summary>
        [JsonProperty("buyerDetails")]
        public ShipmentPickupDetailRequestModel? BuyerDetails { get; set; }

        /// <summary>
        /// The importer details
        /// </summary>
        [JsonProperty("importerDetails")]
        public ShipmentPickupDetailRequestModel? ImporterDetails { get; set; }

        /// <summary>
        /// The exporter details
        /// </summary>
        [JsonProperty("exporterDetails")]
        public ShipmentPickupDetailRequestModel? ExporterDetails { get; set; }

        /// <summary>
        /// The seller details
        /// </summary>
        [JsonProperty("sellerDetails")]
        public ShipmentPickupDetailRequestModel? SellerDetails { get; set; }

        /// <summary>
        /// The payer details
        /// </summary>
        [JsonProperty("payerDetails")]
        public ShipmentPickupDetailRequestModel? PayerDetails { get; set; }

        /// <summary>
        /// The ultimate consignee details
        /// </summary>
        [JsonProperty("ultimateConsigneeDetails")]
        public EntityProfileDetailRequestModel? UltimateConsigneeDetails { get; set; }

        /// <summary>
        /// Please enter address and contact details related to broker
        /// </summary>
        [JsonProperty("brokerDetails")]
        public EntityProfileDetailRequestModel? BrokerDetails { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public EntityProfileRequestModel() : base()
        {

        }

        #endregion
    }
}