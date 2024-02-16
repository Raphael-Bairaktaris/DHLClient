using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a customer detail
    /// </summary>
    public class ShipmentCustomerDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The shipper details
        /// </summary>
        [JsonProperty("shipperDetails")]
        public ShipmentCustomerDetailLineRequestModel? ShipperDetails { get; set; }

        /// <summary>
        /// The receiver details
        /// </summary>
        [JsonProperty("receiverDetails")]
        public ShipmentCustomerDetailLineRequestModel? ReceiverDetails { get; set; }

        /// <summary>
        /// The buyer details
        /// </summary>
        [JsonProperty("buyerDetails")]
        public ShipmentCustomerDetailLineRequestModel? BuyerDetails { get; set; }

        /// <summary>
        /// The importer details
        /// </summary>
        [JsonProperty("importerDetails")]
        public ShipmentCustomerDetailLineRequestModel? ImporterDetails { get; set; }

        /// <summary>
        /// The exporter details
        /// </summary>
        [JsonProperty("exporterDetails")]
        public ShipmentCustomerDetailLineRequestModel? ExporterDetails { get; set; }

        /// <summary>
        /// The seller details
        /// </summary>
        [JsonProperty("sellerDetails")]
        public ShipmentCustomerDetailLineRequestModel? SellerDetails { get; set; }

        /// <summary>
        /// The payer details
        /// </summary>
        [JsonProperty("payerDetails")]
        public ShipmentCustomerDetailLineRequestModel? PayerDetails { get; set; }

        /// <summary>
        /// The ultimate consignee details
        /// </summary>
        [JsonProperty("ultimateConsigneeDetails")]
        public ShipmentCustomerDetailLineRequestModel? UltimateConsigneeDetails { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentCustomerDetailRequestModel() : base()
        {

        }

        #endregion
    }
}