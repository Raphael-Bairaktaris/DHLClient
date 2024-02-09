using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Represents a rating product response
    /// </summary>
    public class RatingProductResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Products"/> property
        /// </summary>
        private IEnumerable<ProductDetailResponseModel> mProducts;

        /// <summary>
        /// The member of the <see cref="ExchangeRates"/> property
        /// </summary>
        private IEnumerable<RatingExchangeRatesResponseModel> mExchangeRates;

        /// <summary>
        /// The member of the <see cref="Warnings"/>
        /// </summary>
        private IEnumerable<string> mWarnings;

        #endregion

        #region Public Properties

        /// <summary>
        /// The products
        /// </summary>
        [JsonProperty("products")]
        public IEnumerable<ProductDetailResponseModel> Products 
        {
            get => mProducts ?? Enumerable.Empty<ProductDetailResponseModel>();
            set => mProducts = value;
        }

        /// <summary>
        /// The exchange rates
        /// </summary>
        [JsonProperty("exchangeRates")]
        public IEnumerable<RatingExchangeRatesResponseModel> ExchangeRates 
        { 
            get => mExchangeRates ?? Enumerable.Empty<RatingExchangeRatesResponseModel>();
            set => mExchangeRates = value;
        }

        /// <summary>
        /// The warnings
        /// </summary>
        [JsonProperty("warnings")]
        public IEnumerable<string> Warnings 
        { 
            get => mWarnings ?? Enumerable.Empty<string>();
            set => mWarnings = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RatingProductResponseModel() : base()
        {

        }

        #endregion
    }
}
