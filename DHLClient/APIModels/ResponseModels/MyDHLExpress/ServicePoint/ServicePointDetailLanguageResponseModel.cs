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

        #endregion

        #region Public Properties

        /// <summary>
        /// Language Code
        /// </summary>
        /// <example>eng</example>
        [JsonProperty("languageCode")]
        [JsonConverter(typeof(ThreeLetterLanguageCodeToStringJsonConverter))]
        public ThreeLetterLanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Language Script Code
        /// </summary>
        /// <example>Latn</example>
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
        [JsonConverter(typeof(LanguageCodeToStringJsonConverter))]
        public LanguageCode LanguageCountryCode { get; set; }

        /// <summary>
        /// A flag indicating whether the language is valid
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