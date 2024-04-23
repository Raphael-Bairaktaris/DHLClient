using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment route
    /// </summary>
    public class ShipmentRouteResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="FacilityCode"/> property
        /// </summary>
        private string? mFacilityCode;

        /// <summary>
        /// The member of the <see cref="ServiceAreaCode"/> property
        /// </summary>
        private string? mServiceAreaCode;

        /// <summary>
        /// The member of the <see cref="InboundSortCode"/> property
        /// </summary>
        private string? mInboundSortCode;

        /// <summary>
        /// The member of the <see cref="OutboundSortCode"/> property
        /// </summary>
        private string? mOutboundSortCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// The service area facility code
        /// </summary>
        /// <example>Facility area</example>
        [JsonProperty("facilityCode")]
        public string FacilityCode
        {
            get => mFacilityCode ?? string.Empty;
            set => mFacilityCode = value;
        }

        /// <summary>
        /// The service area code 
        /// </summary>
        [JsonProperty("serviceAreaCode")]
        public string ServiceAreaCode
        {
            get => mServiceAreaCode ?? string.Empty;
            set => mServiceAreaCode = value;
        }

        /// <summary>
        /// The service area inbound sort code
        /// </summary>
        [JsonProperty("inboundSortCode")]
        public string InboundSortCode
        {
            get => mInboundSortCode ?? string.Empty;
            set => mInboundSortCode = value;
        }

        /// <summary>
        /// The service area outbound sort code
        /// </summary>
        [JsonProperty("outboundSortCode")]
        public string OutboundSortCode
        {
            get => mOutboundSortCode ?? string.Empty;
            set => mOutboundSortCode = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentRouteResponseModel() : base()
        {

        }

        #endregion
    }
}