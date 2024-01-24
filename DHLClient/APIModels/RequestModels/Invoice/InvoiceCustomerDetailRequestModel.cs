using Newtonsoft.Json;
using System.Net;
using System.Numerics;

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
        public TradeEntityDetailRequestModel? SellerDetails { get; set; }

        /// <summary>
        /// Please enter address and contact details related to buyer
        /// </summary>
        [JsonProperty("buyerDetails")]
        public TradeEntityDetailRequestModel? BuyerDetails { get; set; }

        /// <summary>
        /// Please enter address and contact details related to importer
        /// </summary>
        [JsonProperty("importerDetails")]
        public TradeEntityDetailRequestModel? ImporterDetails { get; set; }

        /// <summary>
        /// Please enter address and contact details related to exporter
        /// </summary>
        [JsonProperty("exporterDetails")]
        public TradeEntityDetailRequestModel? ExporterDetails { get; set; }

        /// <summary>
        /// Please enter address and contact details related to ultimate consignee
        /// </summary>
        [JsonProperty("ultimateConsigneeDetails")]
        public TradeEntityDetailRequestModel? UltimateConsigneeDetails { get; set; }

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