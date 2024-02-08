using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point location by address response
    /// </summary>
    public class ServicePointLocationResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Keyword"/> property
        /// </summary>
        private string? mKeyword;

        /// <summary>
        /// The member of the <see cref="KeywordId"/> property
        /// </summary>
        private string? mKeywordId;

        /// <summary>
        /// The member of the <see cref="Type"/> property
        /// </summary>
        private IEnumerable<LocationType>? mType;

        #endregion

        #region Public Properties

        /// <summary>
        /// One location can be known within different business units (providerTypes). They will be known under a unique ID within each business unit domain, as provided.
        /// </summary>
        [JsonProperty("location")]
        public IEnumerable<ServicePointLocationByIdsResponseModel> Location
        {
            get => mLocation ?? Enumerable.Empty<ServicePointLocationByIdsResponseModel>();
            set => mLocation = value;
        }

        /// <summary>
        /// Address to put on a label, to send a shipment to a service point or locker for pick up / drop off.
        /// For German locations, keyword and keywordId are placed as street Name and house number, streetAddress
        /// is omitted on the label of a shipment. For locations outside of Germany, keyword and keywordId are placed in addition to streetAddress.
        /// </summary>
        [JsonProperty("keyword")]
        public string Keyword
        {
            get => mKeyword ?? string.Empty;
            set => mKeyword = value;
        }

        /// <summary>
        /// The id belonging to keyword that together with the keyword id build up the streetAddress for direct addressing to a service point or a locker for pick up / drop off.
        /// </summary>
        /// <example> 443 </example>
        [JsonProperty("keywordId")]
        public string KeywordId
        {
            get => mKeywordId ?? string.Empty;
            set => mKeywordId = value;
        }

        /// <summary>
        /// Type of the DHL Service Point location.
        /// </summary>
        /// <example> servicepoint </example>
        [JsonProperty("type")]
        [JsonConverter(typeof(LocationTypeToStringJsonConverter))]
        public LocationType Type { get; set; }

        /// <summary>
        /// Lean lockers can only be operated with a mobile phone.
        /// </summary>
        [JsonProperty("leanLocker")]
        public bool IsLeanLocker { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationResponseModel() : base()
        {

        }

        #endregion
    }
}