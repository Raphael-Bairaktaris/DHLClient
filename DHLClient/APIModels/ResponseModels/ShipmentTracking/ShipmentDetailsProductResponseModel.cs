using Newtonsoft.Json;

namespace DHLClient
{
    public class ShipmentDetailsProductResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="DeliveryMethodMark"/> property
        /// </summary>
        private string? mDeliveryMethodMark;

        /// <summary>
        /// The member of the <see cref="ProductCode"/> property
        /// </summary>
        private string? mProductCode;

        /// <summary>
        /// The member of the <see cref="ProductName"/> property
        /// </summary>
        private string? mProductName;

        #endregion

        #region Public Properties

        /// <summary>
        /// Specific detail of product
        /// </summary>
        /// <example>D2P</example>
        public string DeliveryMethodMark 
        { 
            get => mDeliveryMethodMark ?? string.Empty;
            set => mDeliveryMethodMark = value;
        }

        /// <summary>
        /// The product code
        /// </summary>
        [JsonProperty("productCode")]
        public string ProductCode 
        { 
            get => mProductCode ?? string.Empty;
            set => mProductCode = value;
        }

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
