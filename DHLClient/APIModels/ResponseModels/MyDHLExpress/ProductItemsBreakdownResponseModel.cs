using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DHLClient
{
    /// <summary>
    /// The product items breakdown response
    /// </summary>
    public class ProductItemsBreakdownResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The name of the charge
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Special service or extra charge code. This is the code you would have to use in the 
        /// /shipment service if you wish to add an optional Service such as Saturday delivery
        /// </summary>
        public SpecialServiceChargeCode ServiceCode { get; set; }

        /// <summary>
        /// Local service code
        /// </summary>
        [JsonProperty("localServiceCode")]
        public string LocalServiceCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductItemsBreakdownResponseModel() : base()
        {

        }

        #endregion
    }
}