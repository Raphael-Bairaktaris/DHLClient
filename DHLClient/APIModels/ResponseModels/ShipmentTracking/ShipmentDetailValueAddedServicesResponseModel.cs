using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment detail value added service response
    /// </summary>
    public class ShipmentDetailValueAddedServicesResponseModel
    {
        #region Private Members
        
        /// <summary>
        /// The member of the <see cref="Services"/> property
        /// </summary>
        private ShipmentDetailServicesResponseModel mServices;

        #endregion

        #region Public Properties

        /// <summary>
        /// List of customer services
        /// </summary>
        [JsonProperty("services")]
        public ShipmentDetailServicesResponseModel Services 
        { 
            get => mServices ??= new ShipmentDetailServicesResponseModel();
            set => mServices = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailValueAddedServicesResponseModel() : base()
        {

        }

        #endregion
    }
}