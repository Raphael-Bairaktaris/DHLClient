﻿using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represent a find location response
    /// </summary>
    public class ServicePointLocationByIdsResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="LocationId"/> property
        /// </summary>
        private string? mLocationId;

        /// <summary>
        /// The member of the <see cref="Provider"/> property 
        /// </summary>
        private string? mProvider;

        #endregion

        #region Public Properties

        /// <summary>
        /// The ID as how the location is know within this business unit / provider.
        /// </summary>
        /// <example> 8003-4103535 </example>
        [JsonProperty("locationId")]
        public string LocationId
        {
            get => mLocationId ?? string.Empty;
            set => mLocationId = value;
        }

        /// <summary>
        /// The business unit of the DHL Service Point location.
        /// </summary>
        /// <example> parcel </example>
        [JsonProperty("provider")]
        public string Provider
        {
            get => mProvider ?? string.Empty;
            set => mProvider = value;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationByIdsResponseModel() : base()
        {

        }

        #endregion
    }
}
