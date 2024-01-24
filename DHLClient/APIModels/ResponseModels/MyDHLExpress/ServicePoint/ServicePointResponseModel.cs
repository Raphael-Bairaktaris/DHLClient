using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// The service point response
    /// </summary>
    public class ServicePointResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Status"/> property
        /// </summary>
        private ServicePointStatusResponseModel? mStatus;

        /// <summary>
        /// The member of the <see cref="SearchAddress"/> property
        /// </summary>
        private string? mSearchAddres;

        /// <summary>
        /// The member of the <see cref="SearchLocation"/> property
        /// </summary>
        private ServicePointSearchLocationResponseModel? mSearchLocation;

        /// <summary>
        /// The member of the <see cref="MapCulture"/> property
        /// </summary>
        private string? mMapCulture;

        /// <summary>
        /// The member of the <see cref="MapLanguage"/> property
        /// </summary>
        private string? mMapLanguage;

        /// <summary>
        /// The member of the <see cref="ServicePoints"/> property
        /// </summary>
        private ServicePointDetailResponseModel? mServicePoints;

        #endregion

        #region Public Properties

        /// <summary>
        /// The response status
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
            get => mSearchAddres ?? string.Empty;
            set => mSearchAddres = value;
        }

        /// <summary>
        /// The geographical coordinates of the facility's location
        /// </summary>
        [JsonProperty("searchLocation")]
        public ServicePointSearchLocationResponseModel SearchLocation 
        { 
            get => mSearchLocation ??= new ServicePointSearchLocationResponseModel();
            set => mSearchLocation = value;
        }

        /// <summary>
        /// The culture parameter for Bing Maps API (derived from the country parameter in the request)
        /// </summary>
        [JsonProperty("mapCulture")]
        public string MapCulture 
        { 
            get => mMapCulture ?? string.Empty;
            set => mMapCulture = value;
        }

        /// <summary>
        /// Map Culture Used for Third party Maps
        /// </summary>
        [JsonProperty("mapLanguage")]
        public string MapLanguage 
        { 
            get => mMapLanguage ?? string.Empty;
            set => mMapLanguage = value;
        }

        /// <summary>
        /// Array of the found Service Points. Each Service Point entity contains details about the service point.
        /// </summary>
        [JsonProperty("servicePoints")]
        public ServicePointDetailResponseModel ServicePoints 
        { 
            get => mServicePoints ??= new ServicePointDetailResponseModel();
            set => mServicePoints = value;
        }

        /// <summary>
        /// Sub-entity holding the facility address 
        /// </summary>
        [JsonProperty("address")]
        public ServicePointAddressResponseModel Address { get; set; }

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
