using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment tracking detail response
    /// </summary>
    public class ShipmentTrackingDetailsResponseModel
    {
        #region MyRegion

        /// <summary>
        /// The member of the <see cref="Id"/> property
        /// </summary>
        private string? mId;

        /// <summary>
        /// The member of the <see cref="Origin"/> property
        /// </summary>
        private ShipmentLocationResponseModel? mOrigin;

        /// <summary>
        /// The member of the <see cref="Destination"/> property
        /// </summary>
        private ShipmentLocationResponseModel? mDestination;

        /// <summary>
        /// The member of the <see cref="Status"/> property
        /// </summary>
        private ShipmentStatusResponseModel? mStatus;

        /// <summary>
        /// The member of the <see cref="EstimatedDeliveryTimeFrameResponseModel"/> property
        /// </summary>
        private ShipmentEstimatedDeliveryTimeFrameResponseModel? mEstimatedDeliveryTimeFrame;

        /// <summary>
        /// The member of the <see cref="EstimatedTimeOfDeliveryRemark"/> property
        /// </summary>
        private string? mEstimatedTimeOfDeliveryRemark;

        /// <summary>
        /// The member of the <see cref="ServiceUrl"/> property
        /// </summary>
        private string? mServiceURL;

        /// <summary>
        /// The member of the <see cref="RerouteURL"/> property
        /// </summary>
        private string? mRerouteURL;

        /// <summary>
        /// The member of the <see cref="Details"/> property
        /// </summary>
        private ShipmentDetailsResponseModel? mDetails;

        /// <summary>
        /// The member of the <see cref="Events"/> property
        /// </summary>
        private IEnumerable<ShipmentEventsResponseModel>? mEvents;

        /// <summary>
        /// The member of the <see cref="PossibleAdditionalShipmentsURL"/> property
        /// </summary>
        private IEnumerable<string>? mPossibleAdditionalShipmentsURL;

        #endregion

        #region Public Properties

        /// <summary>
        /// The Id
        /// </summary>
        public string Id
        {
            get => mId ?? string.Empty;
            set => mId = value;
        }

        /// <summary>
        /// The shipment service type
        /// </summary>
        [JsonProperty("service")]
        public ShipmentServiceType Service { get; set; }

        /// <summary>
        /// The shipment origin
        /// </summary>
        [JsonProperty("origin")]
        public ShipmentLocationResponseModel Origin 
        {   
            get => mOrigin ??= new ShipmentLocationResponseModel();
            set => mOrigin = value;
        }

        /// <summary>
        /// The shipment destination
        /// </summary>
        [JsonProperty("destination")]
        public ShipmentLocationResponseModel Destination 
        { 
            get => mDestination ??= new ShipmentLocationResponseModel();
            set => mDestination = value;
        }

        /// <summary>
        /// The shipment status
        /// </summary>
        [JsonProperty("status")]
        public ShipmentStatusResponseModel Status 
        { 
            get => mStatus ??= new ShipmentStatusResponseModel();
            set => mStatus = value;
        }

        /// <summary>
        /// The estimated time of delivery
        /// </summary>
        [JsonProperty("estimatedTimeOfDelivery")]
        public DateTimeOffset? EstimatedTimeOfDelivery { get; set; }

        /// <summary>
        /// The estimated delivery time frame
        /// </summary>
        [JsonProperty("estimatedDeliveryTimeFrame")]
        public ShipmentEstimatedDeliveryTimeFrameResponseModel EstimatedDeliveryTimeFrameResponseModel 
        { 
            get => mEstimatedDeliveryTimeFrame ??= new ShipmentEstimatedDeliveryTimeFrameResponseModel();
            set => mEstimatedDeliveryTimeFrame = value; 
        }

        /// <summary>
        /// The estimated time of delivery remark
        /// </summary>
        [JsonProperty("estimatedTimeOfDeliveryRemark")]
        public string EstimatedTimeOfDeliveryRemark 
        { 
            get => mEstimatedTimeOfDeliveryRemark ?? string.Empty;
            set => mEstimatedTimeOfDeliveryRemark = value;
        }

        /// <summary>
        /// The service URL
        /// </summary>
        /// <remarks> http://www.dhl.de/de/privatkunden.html?piececode=7777777770 </remarks>
        [JsonProperty("serviceUrl")]
        public string ServiceURL 
        { 
            get => mServiceURL ?? string.Empty;
            set => mServiceURL = value;
        }

        /// <summary>
        /// The rerouted URL
        /// </summary>
        /// <remarks> https://www.dhl.de/de/privatkunden.html?piececode=7777777770&verfuegen_selected_tab=FIRST </remarks>
        [JsonProperty("rerouteUrl")]
        public string RerouteURL 
        { 
            get => mRerouteURL ?? string.Empty;
            set => mRerouteURL = value;
        }

        /// <summary>
        /// The shipment details
        /// </summary>
        [JsonProperty("details")]
        public ShipmentDetailsResponseModel Details 
        { 
            get => mDetails ??= new ShipmentDetailsResponseModel();
            set => mDetails = value;
        }

        /// <summary>
        /// The shipment events
        /// </summary>
        [JsonProperty("events")]
        public IEnumerable<ShipmentEventsResponseModel> Events 
        { 
            get => mEvents ?? Enumerable.Empty<ShipmentEventsResponseModel>();
            set => mEvents = value;
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
        public ShipmentTrackingDetailsResponseModel() : base()
        {

        }

        #endregion
    }
}
