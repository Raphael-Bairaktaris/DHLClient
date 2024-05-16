using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a geographical location suggestion response
    /// </summary>
    public class GeographicalLocationSuggestionResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Label"/> property
        /// </summary>
        private string? mLabel;

        /// <summary>
        /// The member of the <see cref="Value"/> property
        /// </summary>
        private string? mValue;

        /// <summary>
        /// The member of the <see cref="PlaceId"/> property
        /// </summary>
        private string? mPlaceId;

        /// <summary>
        /// The member of the <see cref="ProviderId"/> property
        /// </summary>
        private string? mProviderId;

        #endregion

        #region Public Properties

        /// <summary>
        /// Always holds null value
        /// </summary>
        [JsonProperty("label")]
        public string Label
        {
            get => mLabel ?? string.Empty;
            set => mLabel = value;
        }

        /// <summary>
        /// Always holds null value
        /// </summary>
        [JsonProperty("value")]
        public string Value
        {
            get => mValue ?? string.Empty;
            set => mValue = value;
        }

        /// <summary>
        /// The geographical coordinates
        /// </summary>
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Country code of the search address
        /// </summary>
        [JsonProperty("countryCode")]
        [JsonConverter(typeof(CountryCodeToStringJsonConverter))]
        public CountryCode CountryCode { get; set; }

        /// <summary>
        /// Place id of the search address
        /// </summary>
        [JsonProperty("placeId")]
        public string PlaceId
        {
            get => mPlaceId ?? string.Empty;
            set => mPlaceId = value;
        }

        /// <summary>
        /// Provider id of the search address
        /// </summary>
        [JsonProperty("providerId")]
        public string ProviderId
        {
            get => mProviderId ?? string.Empty;
            set => mProviderId = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public GeographicalLocationSuggestionResponseModel() : base()
        {

        }

        #endregion
    }
}