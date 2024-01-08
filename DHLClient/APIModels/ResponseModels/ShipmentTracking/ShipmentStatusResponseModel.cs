using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Represent a shipment status response
    /// </summary>
    public class ShipmentStatusResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Timestamp"/> property
        /// </summary>
        private string? mTimestamp;

        /// <summary>
        /// The member of the <see cref="Location"/> property
        /// </summary>
        private ShipmentLocationResponseModel? mLocation;

        /// <summary>
        /// The member of the <see cref="Status"/> property
        /// </summary>
        private string? mStatus;

        /// <summary>
        /// The member of the <see cref="Description"/> property
        /// </summary>
        private string? mDescription;

        /// <summary>
        /// The member of the <see cref="PlaceIds"/> property
        /// </summary>
        private IEnumerable<string>? mPlaceIds;

        /// <summary>
        /// The member of the <see cref="Remark"/> property
        /// </summary>
        private string? mRemark;

        /// <summary>
        /// The member of the <see cref="NextSteps"/>
        /// </summary>
        private IEnumerable<string>? mNextSteps;

        #endregion

        #region Public Properties

        /// <summary>
        /// The time stamp
        /// </summary>
        [JsonProperty("timestamp")]
        public string Timestamp 
        { 
            get => mTimestamp ?? string.Empty;
            set => mTimestamp = value;
        }

        /// <summary>
        /// The location
        /// </summary>
        [JsonProperty("location")]
        public ShipmentLocationResponseModel Location 
        { 
            get => mLocation ??= new ShipmentLocationResponseModel();
            set => mLocation = value;
        }

        /// <summary>
        /// The status code
        /// </summary>
        [JsonProperty("statusCode")]
        public StatusCodeType? StatusCode { get; set; }

        /// <summary>
        /// The shipment status
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        {
            get => mStatus ?? string.Empty;
            set => mStatus = value;
        }

        /// <summary>
        /// The description
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        /// <summary>
        /// The place ids
        /// </summary>
        [JsonProperty("placeIds")]
        public IEnumerable<string> PlaceIds 
        { 
            get => mPlaceIds ?? Enumerable.Empty<string>();
            set => mPlaceIds = value;
        }

        /// <summary>
        /// The remark
        /// </summary>
        /// <example> The shipment is pending completion of customs inspection. </example>
        [JsonProperty("remark")]
        public string Remark 
        { 
            get => mRemark ?? string.Empty;
            set => mRemark = value;
        }

        /// <summary>
        /// The next steps
        /// </summary>
        [JsonProperty("nextSteps")]
        public IEnumerable<string> NextSteps 
        { 
            get => mNextSteps ?? Enumerable.Empty<string>();
            set => mNextSteps = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentStatusResponseModel() : base()
        {

        }

        #endregion
    }
}
