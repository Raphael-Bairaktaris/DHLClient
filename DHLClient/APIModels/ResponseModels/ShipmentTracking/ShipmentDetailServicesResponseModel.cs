﻿using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment detail services response
    /// </summary>
    public class ShipmentDetailServicesResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The shipping option
        /// </summary>
        [JsonProperty("serviceType")]
        [JsonConverter(typeof(ShippingOptionToStringJsonConverter))]
        public ShippingOption ServiceType { get; set; }

        /// <summary>
        /// The service criteria
        /// </summary>
        [JsonProperty("serviceCriteria")]
        public string ServiceCriteria { get; set; }

        /// <summary>
        /// Indicates whether the shipment has value added services
        /// </summary>
        [JsonProperty("serviceFlag")]
        public bool ServiceFlag { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailServicesResponseModel() : base()
        {

        }

        #endregion
    }
}