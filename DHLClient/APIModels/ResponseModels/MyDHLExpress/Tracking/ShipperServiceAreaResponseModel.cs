using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipper service area response
    /// </summary>
    public class ShipperServiceAreaResponseModel
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
        /// The member of the <see cref="OutboundSortCode"/> property
        /// </summary>
        private string? mOutboundSortCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// The service area code
        /// </summary>
        /// <example>ABC</example>
        [JsonProperty("code")]
        public string Code 
        { 
            get => mCode ?? string.Empty;
            set => mCode = value;
        }

        /// <summary>
        /// The service area description
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get => mDescription ?? string.Empty;
            set => mDescription = value;
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
        public ShipperServiceAreaResponseModel() : base()
        {

        }

        #endregion
    }
}