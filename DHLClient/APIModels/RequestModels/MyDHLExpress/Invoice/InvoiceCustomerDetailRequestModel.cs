using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a trade entity
    /// </summary>
    public class InvoiceCustomerDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter address and contact details related to seller
        /// </summary>
        [JsonProperty("sellerDetails")]
        public EntityProfileDetailRequestModel? SellerDetails { get; set; }

        /// <summary>
        /// Please enter address and contact details related to buyer
        /// </summary>
        [JsonProperty("buyerDetails")]
        public EntityProfileDetailRequestModel? BuyerDetails { get; set; }

        /// <summary>
        /// Please enter address and contact details related to importer
        /// </summary>
        [JsonProperty("importerDetails")]
        public EntityProfileDetailRequestModel? ImporterDetails { get; set; }

        /// <summary>
        /// Please enter address and contact details related to exporter
        /// </summary>
        [JsonProperty("exporterDetails")]
        public EntityProfileDetailRequestModel? ExporterDetails { get; set; }

        /// <summary>
        /// Please enter address and contact details related to ultimate consignee
        /// </summary>
        [JsonProperty("ultimateConsigneeDetails")]
        public EntityProfileDetailRequestModel? UltimateConsigneeDetails { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceCustomerDetailRequestModel() : base()
        {

        }

        #endregion
    }
}