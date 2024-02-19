using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating a shipment notification
    /// </summary>
    public class ShipmentNotificationDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter channel type to send the notification by. At this moment only email is supported
        /// </summary>
        [JsonRequired]
        [JsonProperty("typeCode")]
        public ChannelType? TypeCode { get; set; }

        /// <summary>
        /// Please enter notification receiver email address
        /// </summary>
        [JsonRequired]
        [JsonProperty("receiverId")]
        public string? ReceiverId { get; set; }

        /// <summary>
        /// Please enter three letter language code in which you wish to receive the notification in
        /// List of supported language code: eng:English, zho:Chinese Traditional, chi:Chinese Simplified, dan:Danish, ita:Italian.
        /// </summary>
        [JsonProperty("languageCode")]
        [JsonConverter(typeof(ThreeLetterLanguageCodeToStringJsonConverter))]
        public ThreeLetterLanguageCode? LanguageCode { get; set; }


        /// <summary>
        /// Please enter two letter language country code. 
        /// List of support country code: CH,GB,US,DK,IT
        /// </summary>
        [JsonProperty("languageCountryCode")]
        [JsonConverter(typeof(LanguageCodeToStringJsonConverter))]
        public LanguageCode? LanguageCountryCode { get; set; }

        /// <summary>
        /// Please enter your message which will be added to the DHL Express notification email
        /// </summary>
        [JsonProperty("bespokeMessage")]
        public string? BespokeMessage { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentNotificationDetailRequestModel() : base()
        {

        }

        #endregion
    }
}