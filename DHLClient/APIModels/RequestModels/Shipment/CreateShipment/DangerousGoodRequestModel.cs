using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a dangerous good
    /// </summary>
    public class DangerousGoodRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter valid DHL Express Dangerous good content id (please contact your DHL Express IT representative for the relevant content ID code if you are shipping Dan
        /// </summary>
        [JsonRequired]
        [JsonProperty("contentId")]
        public string? ContentId { get; set; }

        /// <summary>
        /// Please enter dry ice total net weight when shipping dry ice
        /// </summary>
        [JsonProperty("dryIceTotalWeight")]
        public double? DryIceTotalWeight { get; set; }

        /// <summary>
        /// The customDescription node contains the customized Dangerous Goods statement to declare contents accurately. 
        /// The customDescription node value will be displayed in the Transport Label and Waybill Document, 
        /// replacing the default IATA Dangerous Goods statement constructed based on contentId node.
        /// </summary>
        [JsonProperty("customDescription")]
        public string? CustomDescription { get; set; }

        /// <summary>
        /// Please enter UN code(s)
        /// </summary>
        [JsonProperty("unCodes")]
        public IEnumerable<string>? UnCodes { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DangerousGoodRequestModel() : base()
        {

        }

        #endregion
    }
}