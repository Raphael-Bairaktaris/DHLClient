using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating the line item weight
    /// </summary>
    public class LineItemWeightRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter the net weight value 
        /// </summary>
        [JsonRequired]
        [JsonProperty("netValue")]
        public double NetValue { get; set; }

        /// <summary>
        /// Please enter the gross weight value
        /// </summary>
        [JsonRequired]
        [JsonProperty("grossValue")]
        public double GrossValue { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LineItemWeightRequestModel() : base()
        {

        }

        #endregion
    }
}