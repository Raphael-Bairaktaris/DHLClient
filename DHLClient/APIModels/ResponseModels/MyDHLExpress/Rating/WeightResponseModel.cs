﻿using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a rating product weight response
    /// </summary>
    public class WeightResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The dimensional weight of the shipment
        /// </summary>
        [JsonProperty("volumetric")]
        public double Volumetric { get; set; }

        /// <summary>
        /// The quoted weight of the shipment
        /// </summary>
        [JsonProperty("provided")]
        public double Provided { get; set; }

        /// <summary>
        /// The unit of measurement for the dimensions of the package.
        /// </summary>
        [JsonProperty("unitOfMeasurment")]
        [JsonConverter(typeof(MeasurmentUnitToStringJsonConverter))]
        public MeasurmentUnit UnitOfMeasurment { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public WeightResponseModel() : base()
        {

        }

        #endregion
    }
}