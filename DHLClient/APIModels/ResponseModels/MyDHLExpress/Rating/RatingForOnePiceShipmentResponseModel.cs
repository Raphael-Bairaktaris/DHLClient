using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Represents a rating for one piece shipment response
    /// </summary>
    public class RatingForOnePiceShipmentResponseModel
    {
        #region Constructors

        /// <summary>
        /// The member of the <see cref="Products"/> property
        /// </summary>
        private IEnumerable<ProductsResponseModel> mProducts;

        #endregion

        #region Public Properties

        /// <summary>
        /// The products
        /// </summary>
        [JsonProperty("products")]
        public IEnumerable<ProductsResponseModel> Products { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RatingForOnePiceShipmentResponseModel() : base()
        {

        }

        #endregion
    }
}
