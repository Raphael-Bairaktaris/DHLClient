using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment tracking response
    /// </summary>
    public class ShipmentTrackingResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="URL"/> property
        /// </summary>
        private string? mURL;

        /// <summary>
        /// The member of the <see cref="PrevURL"/> property
        /// </summary>
        private string? mPrevURL;

        /// <summary>
        /// The member of the <see cref="NetxURL"/> property
        /// </summary>
        private string? mNextURL;

        /// <summary>
        /// The member of the <see cref="FirstURL"/> property
        /// </summary>
        private string? mFirstURL;

        /// <summary>
        /// The member of the <see cref="LastURL"/> property
        /// </summary>
        private string? mLastURL;

        /// <summary>
        /// The member of the <see cref="Shipments"/> property
        /// </summary>
        private ShipmentTrackingDetailsResponseModel? mShipments;

        /// <summary>
        /// The member of the <see cref="PossibleAdditionalShipmentsURL"/> property
        /// </summary>
        private IEnumerable<string>? mPossibleAdditionalShipmentsURL;
        #endregion

        #region Public Property

        /// <summary>
        /// The URL
        /// </summary>
        [JsonProperty("url")]
        public string URL 
        {
            get => mURL ?? string.Empty;
            set => mURL = value;
        }

        /// <summary>
        /// The previous URL
        /// </summary>
        [JsonProperty("prevUrl")]
        public string PrevURL 
        { 
            get => mPrevURL ?? string.Empty;
            set => mPrevURL = value;
        }

        /// <summary>
        /// The next URL
        /// </summary>
        [JsonProperty("nextUrl")]
        public string NextURL 
        { 
            get => mNextURL ?? string.Empty;
            set => mNextURL = value;
        }

        /// <summary>
        /// The first URL
        /// </summary>
        [JsonProperty("firstUrl")]
        public string FirstURL 
        { 
            get => mFirstURL ?? string.Empty;
            set => mFirstURL = value;
        }

        /// <summary>
        /// The last URL
        /// </summary>
        [JsonProperty("lastUrl")]
        public string LastURL 
        { 
            get => mLastURL ?? string.Empty;
            set => mLastURL = value;
        }

        /// <summary>
        /// The shipments details
        /// </summary>
        [JsonProperty("shipments")]
        public ShipmentTrackingDetailsResponseModel Shipments 
        { 
            get => mShipments ??= new ShipmentTrackingDetailsResponseModel();
            set => mShipments = value;
        }

        /// <summary>
        /// The possible additional shipments URL
        /// </summary>
        [JsonProperty("possibleAdditionalShipmentsURL")]
        public IEnumerable<string> PossibleAdditionalShipmentsURL 
        { 
            get => mPossibleAdditionalShipmentsURL ?? Enumerable.Empty<string>();
            set => mPossibleAdditionalShipmentsURL = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentTrackingResponseModel() : base()
        {

        }

        #endregion
    }
}
