﻿using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point response
    /// </summary>
    public class ServicePointResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Status"/> property
        /// </summary>
        private ServicePointStatusResponseModel mStatus;

        /// <summary>
        /// The member of the <see cref="SearchAddress"/> property
        /// </summary>
        private string? mSearchAddress;

        /// <summary>
        /// The member of the <see cref="SearchLocation"/> property
        /// </summary>
        private ServicePointSearchLocationResponseModel mSearchLocation;

        /// <summary>
        /// the member of the <see cref="MapCulture"/> property
        /// </summary>
        private string? mMapCulture;

        /// <summary>
        /// The member of the <see cref="MapLanguage"/> property
        /// </summary>
        private string? mMapLanguage;

        #endregion

        #region Public Properties

        /// <summary>
        /// Response status
        /// </summary>
        [JsonProperty("status")]
        public ServicePointStatusResponseModel Status
        {
            get => mStatus ??= new ServicePointStatusResponseModel();
            set => mStatus = value;
        }

        /// <summary>
        /// The address used for the search (value of request parameter 'address')
        /// </summary>
        [JsonProperty("searchAddress")]
        public string SearchAddress
        {
            get => mSearchAddress ?? string.Empty;
            set => mSearchAddress = value;
        }

        /// <summary>
        /// The geographical coordinates of the facility’s location
        /// </summary>
        [JsonProperty("searchLocation")]
        public ServicePointSearchLocationResponseModel SearchLocation { get; set; }

        /// <summary>
        /// The culture parameter for Bing Maps API (derived from the country parameter in the request)
        /// </summary>
        [JsonProperty("mapCulture")]
        public string MapCulture { get; set; }

        /// <summary>
        /// Map Culture Used for Third party Maps
        /// </summary>
        [JsonProperty("mapLanguage")]
        public string MapLanguage { get; set; }

        /// <summary>
        /// Array of the found Service Points. Each Service Point entity contains details about the service point.
        /// </summary>
        [JsonProperty("servicePoints")]
        public ServicePointDetailResponseModel ServicePoints { get; set; }

        /// <summary>
        /// Array of strings. Contains information messages
        /// </summary>
        /// <example>required language is not available, result was filtered due to incoming holidays.</example>
        [JsonProperty("messages")]
        public IEnumerable<string> Messages { get; set; }

        /// <summary>
        /// The translations
        /// </summary>
        [JsonProperty("translations")]
        public ServicePointTranslationResponseModel Translations { get; set; }

        /// <summary>
        /// Indicates whether lite mode is activated or not.
        /// </summary>
        [JsonProperty("liteMode")]
        public bool HasLiteMode { get; set; }

        /// <summary>
        /// Promotion on a SVP level
        /// </summary>
        [JsonProperty("promotion")]
        public ServicePointPromotionResponseModel Promotion { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointResponseModel() : base()
        {

        }

        #endregion
    }
}
