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
        /// The member of the <see cref="PartnerTypeCode"/> property
        /// </summary>
        private string? mPartnerTypeCode;

        /// <summary>
        /// The member of the <see cref="ServicePointId"/> property
        /// </summary>
        private string? mServicePointId;

        /// <summary>
        /// The member of the <see cref="ClientId"/> property
        /// </summary>
        private string? mClientId;

        /// <summary>
        /// The member of the <see cref="Capability"/> property
        /// </summary>
        private string? mCapability;

        /// <summary>
        /// The member of the <see cref="Text1"/> property
        /// </summary>
        private string? mText1;

        /// <summary>
        /// The member of the <see cref="ButtonText1"/> property
        /// </summary>
        private string? mButtonText1;

        /// <summary>
        /// The member of the <see cref="Text2"/> property
        /// </summary>
        private string? mText2;

        /// <summary>
        /// The member of the <see cref="ButtonText2"/> property
        /// </summary>
        private string? mButtonText2;

        /// <summary>
        /// The member of the <see cref="Text3"/> property
        /// </summary>
        private string? mText3;

        /// <summary>
        /// The member of the <see cref="ButtonText3"/> property
        /// </summary>
        private string? mButtonText3;

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
        [JsonConverter(typeof(CountryCodeToStringJsonConverter))]
        public CountryCode CountryCode { get; set; }

        /// <summary>
        /// The partner type code
        /// </summary>
        [JsonProperty("partnerTypeCode")]
        public string PartnerTypeCode
        {
            get => mPartnerTypeCode ?? string.Empty;
            set => mPartnerTypeCode = value;
        }

        /// <summary>
        /// The service point LocationId
        /// </summary>
        [JsonProperty("servicePointId")]
        public string ServicePointId
        {
            get => mServicePointId ?? string.Empty;
            set => mServicePointId = value;
        }

        /// <summary>
        /// The client id
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId
        {
            get => mClientId ?? string.Empty;
            set => mClientId = value;
        }

        /// <summary>
        /// The capability (PPC)
        /// </summary>
        [JsonProperty("capability")]
        public string Capability
        {
            get => mCapability ?? string.Empty;
            set => mCapability = value;
        }

        /// <summary>
        /// Promotion Start Date
        /// </summary>
        [JsonProperty("startDate")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter))]
        public DateOnly StartDate { get; set; }

        /// <summary>
        /// The promotion end date
        /// </summary>
        [JsonProperty("endDate")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter))]
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
        public string Text1
        {
            get => mText1 ?? string.Empty;
            set => mText1 = value;
        }

        /// <summary>
        /// The promotion button text
        /// </summary>
        [JsonProperty("buttonText1")]
        public string ButtonText1
        {
            get => mButtonText1 ?? string.Empty;
            set => mButtonText1 = value;
        }

        /// <summary>
        /// The promotion language code
        /// </summary>
        [JsonProperty("languageCode1")]
        [JsonConverter(typeof(LanguageCodeToStringJsonConverter))]
        public LanguageCode LanguageCode1 { get; set; }

        /// <summary>
        /// The promotion message
        /// </summary>
        [JsonProperty("text2")]
        public string Text2
        {
            get => mText2 ?? string.Empty;
            set => mText2 = value;
        }

        /// <summary>
        /// The promotion button text
        /// </summary>
        [JsonProperty("buttonText2")]
        public string ButtonText2
        {
            get => mButtonText2 ?? string.Empty;
            set => mButtonText2 = value;
        }

        /// <summary>
        /// The promotion language code
        /// </summary>
        [JsonProperty("languageCode2")]
        [JsonConverter(typeof(LanguageCodeToStringJsonConverter))]
        public LanguageCode LanguageCode2 { get; set; }

        /// <summary>
        /// The promotion message
        /// </summary>
        [JsonProperty("text3")]
        public string Text3
        {
            get => mText3 ?? string.Empty;
            set => mText3 = value;
        }

        /// <summary>
        /// The promotion button text
        /// </summary>
        [JsonProperty("buttonText3")]
        public string ButtonText3
        {
            get => mButtonText3 ?? string.Empty;
            set => mButtonText3 = value;
        }

        /// <summary>
        /// The promotion language code
        /// </summary>
        [JsonProperty("languageCode3")]
        [JsonConverter(typeof(LanguageCodeToStringJsonConverter))]
        public LanguageCode LanguageCode3 { get; set; }

        /// <summary>
        /// Promotion web link
        /// </summary>
        [JsonProperty("hyperLink")]
        public Uri? HyperLink { get; set; }

        /// <summary>
        /// Promotion date created
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter))]
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