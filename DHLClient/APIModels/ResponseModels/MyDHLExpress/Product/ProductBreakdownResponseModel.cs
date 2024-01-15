using Newtonsoft.Json;
using System.Xml.Linq;

namespace DHLClient
{
    /// <summary>
    /// Represents a product breakdown response 
    /// </summary>
    public class ProductBreakdownResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Name"/> property
        /// </summary>
        private string? mName;

        /// <summary>
        /// The member of the <see cref="ServiceCode"/> property
        /// </summary>
        private string? mServiceCode;

        /// <summary>
        /// The member of the <see cref="LocalServiceCode"/> property
        /// </summary>
        private string? mLocalServiceCode;

        /// <summary>
        /// The member of the <see cref="TypeCode"/> property
        /// </summary>
        private string? mTypeCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// Breakdown name
        /// </summary>
        /// <example>EXPRESS 12:00 DOC</example>
        [JsonProperty("name")]
        public string Name 
        { 
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// Special service or extra charge code. This is the code you would have to use in the 
        /// /shipment service if you wish to add an optional Service such as Saturday delivery
        /// </summary>
        /// <example>AB</example>
        [JsonProperty("serviceCode")]
        public string ServiceCode
        {
            get => mServiceCode ?? string.Empty;
            set => mServiceCode = value;
        }

        /// <summary>
        /// The local service code
        /// </summary>
        [JsonProperty("localServiceCode")]
        public string LocalServiceCode
        {
            get => mLocalServiceCode ?? string.Empty;
            set => mLocalServiceCode = value;
        }
    

        /// <summary>
        /// Breakdown type code
        /// </summary>
        /// <example>EXPRESS 12:00</example>
        [JsonProperty("typeCode")]
        public string TypeCode
        {
            get => mTypeCode ?? string.Empty;
            set => mTypeCode = value;
        }

        /// <summary>
        /// Special service charge code type for service.
        /// </summary>
        /// <example>XCH</example>
        [JsonProperty("specialTypeCode")]
        public SpecialServiceChargeCode SpecialTypeCode { get; set; }

        /// <summary>
        /// Customer agreement indicator for product and services, if service is offered with prior customer agreement
        /// </summary>
        [JsonProperty("isCustomerAgreement")]
        public bool IsCustomerAgreement { get; set; }

        /// <summary>
        /// Indicator if the special service is marketed service
        /// </summary>
        [JsonProperty("isMarketedService")]
        public bool IsMarketedService { get; set; }

        /// <summary>
        /// Indicator is there is any discount allowed
        /// </summary>
        [JsonProperty("isBillingServiceIndicator")]
        public bool IsBillingServiceIndicator { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductBreakdownResponseModel() : base()
        {

        }

        #endregion
    }
}