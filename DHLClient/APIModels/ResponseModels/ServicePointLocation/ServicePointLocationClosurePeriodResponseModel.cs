using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents the closing periods of a DHL service point location
    /// </summary>
    public class ServicePointLocationClosurePeriodResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Type"/> property
        /// </summary>
        private string? mType;

        #endregion

        #region Public Properties

        /// <summary>
        /// Reason for the closure
        /// </summary>
        [JsonProperty("type")]
        public string Type 
        { 
            get => mType ?? string.Empty;
            set => mType = value;
        }

        /// <summary>
        /// A date value in ISO 8601 format (`2017-06-21`) or a combination of date and time of day (`2017-06-21T14:07:17Z`)
        /// </summary>
        /// <example>2018-03-02T07:53:47Z</example>
        [JsonProperty("fromDate")]
        public DateTimeOffset FromDate { get; set; }

        /// <summary>
        /// A date value in ISO 8601 format (`2017-06-21`) or a combination of date and time of day (`2017-06-21T14:07:17Z`)
        /// </summary>
        /// <example>2018-03-02T07:53:47Z</example>
        [JsonProperty("toDate")]
        public DateTimeOffset ToDate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationClosurePeriodResponseModel() : base()
        {

        }

        #endregion
    }
}
