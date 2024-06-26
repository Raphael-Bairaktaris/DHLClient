﻿using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a base product price breakdown response
    /// </summary>
    public class ProductTotalPriceBreakdownResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="PriceBreakdown"/> property
        /// </summary>
        private IEnumerable<ProductPriceBreakdownResponseModel>? mPriceBreakdown;

        #endregion

        #region Public Properties

        /// <summary>
        /// The currency type
        /// </summary>
        [JsonProperty("currencyType")]
        [JsonConverter(typeof(CurrencyTypeToStringJsonConverter))]
        public CurrencyType CurrencyType { get; set; }

        /// <summary>
        /// This the currency of the rated shipment for the prices listed.
        /// </summary>
        [JsonProperty("priceCurrency")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode PriceCurrency { get; set; }

        /// <summary>
        /// The price breakdown
        /// </summary>
        [JsonProperty("priceBreakdown")]
        public IEnumerable<ProductPriceBreakdownResponseModel> PriceBreakdown
        {
            get => mPriceBreakdown ?? Enumerable.Empty<ProductPriceBreakdownResponseModel>();
            set => mPriceBreakdown = value;
        }


        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductTotalPriceBreakdownResponseModel() : base()
        {

        }

        #endregion
    }
}