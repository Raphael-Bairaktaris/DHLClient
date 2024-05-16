using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a service point detail geographical location response
    /// </summary>
    public class ServicePointDetailGeograpgicalLocationResponseModel
    {
        #region Private members

        /// <summary>
        /// The member of the <see cref="Suggestion"/> property
        /// </summary>
        private GeographicalLocationSuggestionResponseModel? mSuggestion;

        #endregion

        #region Public Properties

        /// <summary>
        /// The geographical coordinates
        /// </summary>
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Suggestion for the search address
        /// </summary>
        [JsonProperty("suggestion")]
        public GeographicalLocationSuggestionResponseModel Suggestion
        {
            get => mSuggestion ??= new GeographicalLocationSuggestionResponseModel();
            set => mSuggestion = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointDetailGeograpgicalLocationResponseModel() : base()
        {

        }

        #endregion
    }
}