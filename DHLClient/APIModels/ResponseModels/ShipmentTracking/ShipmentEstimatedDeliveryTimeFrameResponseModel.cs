﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment estimated delivery time frame response
    /// </summary>
    public class ShipmentEstimatedDeliveryTimeFrameResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The estimated delivery time from
        /// </summary>
        /// <example> 2018-08-03T00:00:00Z </example>
        [JsonProperty("estimatedFrom")]
        public DateTimeOffset EstimatedFrom { get; set; }

        /// <summary>
        /// The estimated delivery time through
        /// </summary>
        /// <example> 2018-08-03T00:00:00Z </example>
        [JsonProperty("estimatedThrough")]
        public DateTimeOffset EstimatedThrough { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentEstimatedDeliveryTimeFrameResponseModel() : base()
        {

        }

        #endregion
    }
}
