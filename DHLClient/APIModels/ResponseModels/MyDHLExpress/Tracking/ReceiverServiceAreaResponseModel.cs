using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a receiver service area response
    /// </summary>
    public class ReceiverServiceAreaResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Code"/> property
        /// </summary>
        private string? mCode;

        /// <summary>
        /// The member of the <see cref="Description"/> property
        /// </summary>
        private string? mDescription;

        /// <summary>
        /// The member of the <see cref="FacilityCode"/> property
        /// </summary>
        private string? mFacilityCode;

        /// <summary>
        /// The member of the <see cref="InboundSortCode"/> property
        /// </summary>
        private string? mInboundSortCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// The service area code
        /// </summary>
        /// <example>BSA</example>
        [JsonProperty("code")]
        public string Code
        {
            get => mCode ?? string.Empty;
            set => mCode = value;
        }

        /// <summary>
        /// The service area description 
        /// </summary>
        /// <example>BSA area</example>
        [JsonProperty("description")]
        public string Description
        {
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

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
        /// The service area inbound sort code
        /// </summary>
        [JsonProperty("inboundSortCode")]
        public string InboundSortCode
        {
            get => mInboundSortCode ?? string.Empty;
            set => mInboundSortCode = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ReceiverServiceAreaResponseModel() : base()
        {

        }

        #endregion
    }
}