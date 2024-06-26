﻿using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating charges
    /// </summary>
    public class ChargesRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The cargo type
        /// </summary>
        [JsonRequired]
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(CargoTypeToStringToJsonConverter))]
        public CargoType CargoType { get; set; }

        /// <summary>
        /// The amount
        /// </summary>
        [JsonRequired]
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// The currency code
        /// </summary>
        [JsonRequired]
        [JsonProperty("currencyCode")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode CurrencyCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChargesRequestModel() : base()
        {

        }

        #endregion
    }
}
