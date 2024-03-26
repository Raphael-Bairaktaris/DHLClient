using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a search location response
    /// </summary>
    public class ServicePointSearchLocationResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Suggestion"/> property
        /// </summary>
        private SearchLocationSuggestionResponseModel? mSuggestion;

        #endregion

        #region Public Properties

        /// <summary>
        /// The geographical latitude and longitude
        /// </summary>
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Suggestion for the search address
        /// </summary>
        [JsonProperty("suggestion")]
        public SearchLocationSuggestionResponseModel Suggestion
        {
            get => mSuggestion ?? new SearchLocationSuggestionResponseModel();
            set => mSuggestion = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointSearchLocationResponseModel() : base()
        {

        }

        #endregion
    }
}