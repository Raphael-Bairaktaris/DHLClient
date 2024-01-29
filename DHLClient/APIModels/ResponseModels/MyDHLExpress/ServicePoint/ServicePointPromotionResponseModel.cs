using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point promotion response
    /// </summary>
    public class ServicePointPromotionResponseModel
    {
        #region Private Members

        /// <summary>
        /// 
        /// </summary>
        private string mPartnerTypeCode;

        /// <summary>
        /// 
        /// </summary>
        private string mServicePointId;

        #endregion

        #region Public Properties

        /// <summary>
        /// Unique identifier for promotion
        /// </summary>
        [JsonProperty("id")]
        public double Id { get; set; }

        /// <summary>
        /// The country code
        /// </summary>
        [JsonProperty("coutnryCode")]
        public CountryCode CountryCode { get; set; }

        /// <summary>
        /// The partner type code
        /// </summary>
        [JsonProperty("partnerTypeCode")]
        public string PartnerTypeCode { get; set; }

        /// <summary>
        /// The service point Id
        /// </summary>
        [JsonProperty("servicePointId")]
        public string ServicePointId { get; set; }

        /// <summary>
        /// The client id
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// The capability (PPC)
        /// </summary>
        [JsonProperty("capability")]
        public string Capability { get; set; }

        /// <summary>
        /// Promotion Start Date
        /// </summary>
        [JsonProperty("startDate")]
        public DateOnly StartDate { get; set; }

        /// <summary>
        /// The promotion end date
        /// </summary>
        [JsonProperty("endDate")]
        public DateOnly EndDate { get; set; }

        /// <summary>
        /// The promotion on specific day of the week
        /// </summary>
        [JsonProperty("dayOfWeek")]
        public DayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// The promotion message
        /// </summary>
        [JsonProperty("text1")]
        public string Text1 { get; set; }

        /// <summary>
        /// The promotion button text
        /// </summary>
        [JsonProperty("buttonText1")]
        public string ButtonText1 { get; set; }

        /// <summary>
        /// The promotion language code
        /// </summary>
        [JsonProperty("languageCode1")]
        public LanguageCode LanguageCode1 { get; set; }

        /// <summary>
        /// The promotion message
        /// </summary>
        [JsonProperty("text2")]
        public string Text2 { get; set; }

        /// <summary>
        /// The promotion button text
        /// </summary>
        [JsonProperty("buttonText2")]
        public string ButtonText2 { get; set; }

        /// <summary>
        /// The promotion language code
        /// </summary>
        [JsonProperty("languageCode2")]
        public LanguageCode LanguageCode2 { get; set; }

        /// <summary>
        /// The promotion message
        /// </summary>
        [JsonProperty("text3")]
        public string Text3 { get; set; }

        /// <summary>
        /// The promotion button text
        /// </summary>
        [JsonProperty("buttonText3")]
        public string ButtonText3 { get; set; }

        /// <summary>
        /// The promotion language code
        /// </summary>
        [JsonProperty("languageCode3")]
        public LanguageCode LanguageCode3 { get; set; }

        /// <summary>
        /// Promotion web link
        /// </summary>
        [JsonProperty("hyperLink")]
        public Uri HyperLink { get; set; }

        /// <summary>
        /// Promotion date created
        /// </summary>
        [JsonProperty("created")]
        public DateOnly Created { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointPromotionResponseModel() : base()
        {

        }

        #endregion
    }
}