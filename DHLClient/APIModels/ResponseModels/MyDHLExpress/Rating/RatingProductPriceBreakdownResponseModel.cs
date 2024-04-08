﻿using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a product price breakdown response
    /// </summary>
    public class RatingProductPriceBreakdownResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The breakdown type
        /// </summary>
        /// <example>SPRQT</example>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(BreakdownTypeToStringJsonConverter))]
        public BreakdownType TypeCode { get; set; }

        /// <summary>
        /// The amount price of DHL product and services
        /// </summary>
        /// <example>114.92</example>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RatingProductPriceBreakdownResponseModel() : base()
        {

        }

        #endregion
    }
}