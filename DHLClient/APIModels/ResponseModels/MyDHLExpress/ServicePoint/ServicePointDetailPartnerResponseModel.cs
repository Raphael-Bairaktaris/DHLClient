using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point detail partner response
    /// </summary>
    public class ServicePointDetailPartnerResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="PartnerId"/> property
        /// </summary>
        private string? mPartnerId;

        /// <summary>
        /// The member of the <see cref="PartnerName"/> property
        /// </summary>
        private string? mPartnerName;

        /// <summary>
        /// The member of the <see cref="PartnerTypeCode"/> property
        /// </summary>
        private string? mPartnerTypeCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// ID of a partner
        /// </summary>
        [JsonProperty("partnerId")]
        public string PartnerId 
        { 
            get => mPartnerId ?? string.Empty;
            set => mPartnerId = value;
        }

        /// <summary>
        /// Name of a partner
        /// </summary>
        [JsonProperty("partnerName")]
        public string PartnerName 
        { 
            get => mPartnerName ?? string.Empty;
            set => mPartnerName = value;
        }

        /// <summary>
        /// Code of a partner
        /// </summary>
        [JsonProperty("partnerTypeCode")]
        public string PartnerTypeCode 
        { 
            get => mPartnerTypeCode ?? string.Empty;
            set => mPartnerTypeCode = value;
        }

        /// <summary>
        /// Promotion on a SVP level
        /// </summary>
        [JsonProperty("")]
        public ServicePointPromotionResponseModel Promotion { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointDetailPartnerResponseModel() : base()
        {

        }

        #endregion
    }
}