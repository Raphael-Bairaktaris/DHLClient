using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point capacity status response
    /// </summary>
    public class ServicePointDetailCapacityStatusResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Severity"/> property
        /// </summary>
        private string? mSeverity;

        /// <summary>
        /// The member of the <see cref="MsgClg"/> property
        /// </summary>
        private string? mMsgClg;

        /// <summary>
        /// The member  of the <see cref="MsgClgd"/> property
        /// </summary>
        private string? mMsgClgd;

        /// <summary>
        /// The member of the <see cref="Description"/> property
        /// </summary>
        private string? mDescription;

        /// <summary>
        /// The member of the <see cref="DetailedDescription"/> property
        /// </summary>
        private string? mDetailedDescription;

        #endregion

        #region Public Properties

        /// <summary>
        /// The severity code
        /// </summary>
        [JsonProperty("sev")]
        public string Severity
        {
            get => mSeverity ?? string.Empty;
            set => mSeverity = value;
        }

        /// <summary>
        /// SCMS
        /// </summary>
        [JsonProperty("msgClg")]
        public string MsgClg
        {
            get => mMsgClg ?? string.Empty;
            set => mMsgClg = value;
        }

        /// <summary>
        /// SCMS Status Code
        /// </summary>
        [JsonProperty("msgClgd")]
        public string MsgClgd
        {
            get => mMsgClgd ?? string.Empty;
            set => mMsgClgd = value;
        }


        /// <summary>
        /// SCMS description of status code
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        /// <summary>
        /// SCMS detailed description
        /// </summary>
        [JsonProperty("dtlDsc")]
        public string DetailedDescription
        {
            get => mDetailedDescription ?? string.Empty;
            set => mDetailedDescription = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointDetailCapacityStatusResponseModel() : base()
        {

        }

        #endregion
    }
}