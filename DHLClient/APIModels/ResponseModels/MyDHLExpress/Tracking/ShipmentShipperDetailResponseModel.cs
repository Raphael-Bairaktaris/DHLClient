using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a shipper detail response
    /// </summary>
    public class ShipmentShipperDetailResponseModel
    {
        #region Private Members

        /// <summary>
        /// the member of the <see cref="Name"/> property
        /// </summary>
        private string? mName;

        /// <summary>
        /// the member of the <see cref="PostalAddress"/> property
        /// </summary>
        private ShipperPostalAddressResponseModel? mPostalAddress;

        /// <summary>
        /// The member of the <see cref="ServiceArea"/> property
        /// </summary>
        private ShipperServiceAreaResponseModel? mServiceArea;

        #endregion

        #region Public Properties

        /// <summary>
        /// The shipper's name
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// The shipper's postal address
        /// </summary>
        [JsonProperty("postalAddress")]
        public ShipperPostalAddressResponseModel PostalAddress
        {
            get => mPostalAddress ??= new ShipperPostalAddressResponseModel();
            set => mPostalAddress = value;
        }

        /// <summary>
        /// The shipper's service area
        /// </summary>
        [JsonProperty("serviceArea")]
        public ShipperServiceAreaResponseModel ServiceArea
        {
            get => mServiceArea ??= new ShipperServiceAreaResponseModel();
            set => mServiceArea = value;
        }

        /// <summary>
        /// The shipper account number
        /// </summary>
        /// <example>123456789</example>
        [JsonProperty("accountNumber")]
        public double AccountNumber { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentShipperDetailResponseModel() : base()
        {

        }

        #endregion
    }
}