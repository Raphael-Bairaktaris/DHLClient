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
        /// The member of the <see cref="Location"/> property
        /// </summary>
        private IEnumerable<ServicePointLocationByIdsResponseModel>? mLocation;

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
        private IEnumerable<ServicePointLocationType>? mType;

        #endregion

        #region Public Properties


        /// <summary>
        /// The location
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
        public IEnumerable<ServicePointLocationType> Type
        {
            get => mType ?? Enumerable.Empty<ServicePointLocationType>();
            set => mType = value;
        }

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