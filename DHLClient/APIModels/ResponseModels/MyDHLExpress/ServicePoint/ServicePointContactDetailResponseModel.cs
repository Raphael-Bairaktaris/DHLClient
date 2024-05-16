using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents service point contact detail response
    /// </summary>
    public class ServicePointContactDetailResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="PhoneNumber"/> property
        /// </summary>
        private string? mPhoneNumber;

        /// <summary>
        /// The member of the <see cref="Email"/> property
        /// </summary>
        private string? mEmail;

        /// <summary>
        /// The member of the <see cref="ServicePointId"/> property
        /// </summary>
        private string? mServicePointId;

        #endregion

        #region Public Properties

        /// <summary>
        /// Phone number of the Service Point
        /// </summary>
        [JsonProperty("phoneNumber")]
        public string PhoneNumber
        {
            get => mPhoneNumber ?? string.Empty;
            set => mPhoneNumber = value;
        }

        /// <summary>
        /// E-Mail address of the Service Point
        /// </summary>
        [JsonProperty("email")]
        public string Email
        {
            get => mEmail ?? string.Empty;
            set => mEmail = value;
        }

        /// <summary>
        /// Link to website of the Service Point
        /// </summary>
        [JsonProperty("linkUri")]
        public Uri? LinkUri { get; set; }

        /// <summary>
        /// Service Point ID
        /// </summary>
        [JsonProperty("servicePointId")]
        public string ServicePointId
        {
            get => mServicePointId ?? string.Empty;
            set => mServicePointId = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointContactDetailResponseModel() : base()
        {

        }

        #endregion
    }
}