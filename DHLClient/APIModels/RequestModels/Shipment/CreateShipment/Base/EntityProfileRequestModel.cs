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
        public EntityProfileDetailRequestModel? ShipperDetails { get; set; }

        /// <summary>
        /// The receiver details
        /// </summary>
        [JsonProperty("receiverDetails")]
        public EntityProfileDetailRequestModel? ReceiverDetails { get; set; }

        /// <summary>
        /// The buyer details
        /// </summary>
        [JsonProperty("buyerDetails")]
        public EntityProfileDetailRequestModel? BuyerDetails { get; set; }

        /// <summary>
        /// The importer details
        /// </summary>
        [JsonProperty("importerDetails")]
        public EntityProfileDetailRequestModel? ImporterDetails { get; set; }

        /// <summary>
        /// The exporter details
        /// </summary>
        [JsonProperty("exporterDetails")]
        public EntityProfileDetailRequestModel? ExporterDetails { get; set; }

        /// <summary>
        /// The seller details
        /// </summary>
        [JsonProperty("sellerDetails")]
        public EntityProfileDetailRequestModel? SellerDetails { get; set; }

        /// <summary>
        /// The payer details
        /// </summary>
        [JsonProperty("payerDetails")]
        public EntityProfileDetailRequestModel? PayerDetails { get; set; }

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