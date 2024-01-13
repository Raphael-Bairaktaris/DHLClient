using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a rating landed cost
    /// </summary>
    public class RatingLandedCostRequestModel : CustomerDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter all the DHL Express accounts and types to be used for this shipment
        /// </summary>
        [JsonRequired]
        [JsonProperty("accounts")]
        public AccountRequestModel? Accounts { get; set; }

        /// <summary>
        /// Please enter DHL Express Global Product code
        /// </summary>
        [JsonProperty("productCode")]
        public string? ProductCode { get; set; }

        /// <summary>
        /// Please enter DHL Express Local Product code
        /// </summary>
        [JsonProperty("localProductCode")]
        public string? LocalProductCode { get; set; }

        /// <summary>
        /// Please enter Unit of measurement
        /// </summary>
        [JsonRequired]
        [JsonProperty("unitOfMeasurement")]
        public MeasurmentUnit? UnitOfMeasurement { get; set; }

        /// <summary>
        /// Currency code for the item price (the product being sold) and freight charge. The Landed Cost calculation result will be returned in this defined currency
        /// </summary>
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
        public ChargesRequestModel? Charges { get; set; }

        /// <summary>
        /// The shipment purpose
        /// </summary>
        [JsonProperty("shipmentPurpose")]
        public ShipmentPurpose ShipmentPurpose { get; set; }

        /// <summary>
        /// The type of transportation
        /// </summary>
        [JsonProperty("transoportationMode")]
        public TransportationMode TransportationMode { get; set; }

        /// <summary>
        /// Carrier being used to ship with.
        /// </summary>
        [JsonProperty("merchantSelectedCarrierName")]
        public CarrierName MerchantSelectedCarrierName { get; set; }

        /// <summary>
        /// Here you can define properties per package
        /// </summary>
        [JsonProperty("packages")]
        public PackageRequestModel? Packages { get; set; }

        /// <summary>
        /// The items
        /// </summary>
        public ItemRequestModel? Items { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RatingLandedCostRequestModel() : base()
        {

        }

        #endregion
    }
}
