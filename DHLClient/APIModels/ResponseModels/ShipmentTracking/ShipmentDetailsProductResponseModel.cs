using Newtonsoft.Json;

namespace DHLClient
{
    public class ShipmentDetailsProductResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ProductName"/> property
        /// </summary>
        private string? mProductName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The product name
        /// </summary>
        [JsonProperty("productName")]
        public string ProductName
        {
            get => mProductName ?? string.Empty;
            set => mProductName = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailsProductResponseModel() : base()
        {

        }

        #endregion
    }
}
