using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point detail language response
    /// </summary>
    public class ServicePointDetailLanguageResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="LanguageScriptCode"/> property
        /// </summary>
        private string? mLanguageScriptCode;

        /// <summary>
        /// The member of the <see cref="LanguageCountryCode"/> property
        /// </summary>
        private string? mLanguageCountryCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// Language Code
        /// </summary>
        [JsonProperty("languageCode")]
        [JsonConverter(typeof(LanguageCodeToStringJsonConverter))]
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Language Script Code
        /// </summary>
        [JsonProperty("languageScriptCode")]
        public string LanguageScriptCode
        {
            get => mLanguageScriptCode ?? string.Empty;
            set => mLanguageScriptCode = value;
        }

        /// <summary>
        /// Language Country Code
        /// </summary>
        [JsonProperty("languageCountryCode")]
        public string LanguageCountryCode
        {
            get => mLanguageCountryCode ?? string.Empty;
            set => mLanguageCountryCode = value;
        }

        /// <summary>
        /// Language valid
        /// </summary>
        [JsonProperty("languageOk")]
        public bool IsLanguageOk { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointDetailLanguageResponseModel() : base()
        {

        }

        #endregion
    }
}