using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point detail response
    /// </summary>
    public class ServicePointDetailResponseModel
    {
        #region Private Members 

        /// <summary>
        /// The member of the <see cref="FacilityId"/> property
        /// </summary>
        private string? mFacilityId;

        /// <summary>
        /// The member of the <see cref="FacilityTypeCode"/> property
        /// </summary>
        private string? mFacilityTypeCode;

        /// <summary>
        /// The member of the <see cref="ServiceAreaCode"/> property
        /// </summary>
        private string? mServiceAreaCode;

        /// <summary>
        /// The member of the <see cref="ServicePointName"/> property
        /// </summary>
        private string? mServicePointName;

        /// <summary>
        /// The member of the <see cref="ServicePointNameFormatted"/> property
        /// </summary>
        private string? mServicePointNameFormatted;

        /// <summary>
        /// the member of the <see cref="LocalName"/> property
        /// </summary>
        private string? mLocalName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The facility ID from GREF database
        /// </summary>
        [JsonProperty("id")]
        public double Id { get; set; }

        /// <summary>
        /// Service Point ID is a unique key with 6 characters, consisting of Service Area for first 3 characters
        /// and the last 3 characters is the Facility code. If address is used id not possible to use.
        /// </summary>
        /// <example>ID = BRU001</example>
        [JsonProperty("facilityId")]
        public string FacilityId 
        { 
            get => mFacilityId ?? string.Empty;
            set => mFacilityId = value;
        }

        /// <summary>
        /// The facility type code from GREF database
        /// </summary>
        [JsonProperty("facilityTypeCode")]
        public string FacilityTypeCode 
        { 
            get => mFacilityTypeCode ?? string.Empty;
            set => mFacilityTypeCode = value;
        }

        /// <summary>
        /// The service point’s Service Area Code
        /// </summary>
        [JsonProperty("serviceAreaCode")]
        public string ServiceAreaCode 
        { 
            get => mServiceAreaCode ?? string.Empty;
            set => mServiceAreaCode = value;
        }

        /// <summary>
        /// Name of the service point
        /// </summary>
        [JsonProperty("servicePointName")]
        public string ServicePointName 
        { 
            get => mServicePointName ?? string.Empty;
            set => mServicePointName = value;
        }

        /// <summary>
        /// Formatted name of the service point
        /// </summary>
        [JsonProperty("servicePointNameFormatted")]
        public string ServicePointNameFormatted 
        { 
            get => mServicePointNameFormatted ?? string.Empty;
            set => mServicePointNameFormatted = value;
        }

        /// <summary>
        /// The local trading name of the Service Point
        /// </summary>
        [JsonProperty("localName")]
        public string LocalName 
        { 
            get => mLocalName ?? string.Empty;
            set => mLocalName = value;
        }

        /// <summary>
        /// The type of the Service Point.
        /// </summary>
        [JsonProperty("servicePointType")]
        public ServicePoint ServicePointType { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointDetailResponseModel() : base()
        {

        }

        #endregion
    }
}