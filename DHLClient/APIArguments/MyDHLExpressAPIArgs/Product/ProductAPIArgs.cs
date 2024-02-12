using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Arguments used for product
    /// </summary>
    public class ProductAPIArgs : BaseMyDHLAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// DHL Express customer account number
        /// </summary>
        [ArgumentName("accountNumber")]
        public double? AccountNumber { get; set; }

        /// <summary>
        /// A short text string code (see values defined in ISO 3166) specifying the shipment origin country.
        /// </summary>
        [ArgumentName("originCountryCode")]
        [QueryArgumentConverter<CountryCodeQueryArgymentConverter>]
        public CountryCode? OriginCountryCode { get; set; }

        /// <summary>
        /// Text specifying the postal code for an address.
        /// </summary>
        [ArgumentName("originPostalCode")]
        public string? OriginPostalCode { get; set; }

        /// <summary>
        /// Text specifying the city name
        /// </summary>
        [ArgumentName("originCityName")]
        public string? OriginCityName { get; set; }

        /// <summary>
        /// A short text string code (see values defined in ISO 3166) specifying the shipment destination country.
        /// </summary>
        [ArgumentName("destinationCountryCode")]
        [QueryArgumentConverter<CountryCodeQueryArgymentConverter>]
        public CountryCode? DestinationCountryCode { get; set; }

        /// <summary>
        /// Text specifying the postal code for an address.
        /// </summary>
        [ArgumentName("destinationPostalCode")]
        public string? DestinationPostalCode { get; set; }

        /// <summary>
        /// Text specifying the city name
        /// </summary>
        [ArgumentName("destinationCityName")]
        public string? DestinationCityName { get; set; }

        /// <summary>
        /// Gross weight of the shipment including packaging.
        /// </summary>
        [ArgumentName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Total length of the shipment including packaging.
        /// </summary>
        [ArgumentName("length")]
        public double? Length { get; set; }

        /// <summary>
        /// Total width of the shipment including packaging.
        /// </summary>
        [ArgumentName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// Total height of the shipment including packaging.
        /// </summary>
        [ArgumentName("height")]
        public double? Height { get; set; }

        /// <summary>
        /// Timestamp represents the date you plan to ship your prospected shipment
        /// </summary>
        [ArgumentName("plannedShippingDate")]
        public DateOnly PlannedShippingDate { get; set; }

        /// <summary>
        /// Indicates if the shipment if customs declarable
        /// </summary>
        [ArgumentName("isCustomsDeclarable")]
        public bool? IsCustomsDeclarable { get; set; }

        /// <summary>
        /// The UnitOfMeasurement node conveys the unit of measurements used in the operation. 
        /// This single value corresponds to the units of weight and measurement which are used throughout the message processing.
        /// </summary>
        [ArgumentName("unitOfMeasurement")]
        [QueryArgumentConverter<MeasurementUnitQueryArgumentConverter>]
        public MeasurmentUnit? UnitOfMeasurement { get; set; }

        /// <summary>
        /// When set to true and there are no products available for given plannedShippingDate then products available for the next possible pickup date are returned
        /// </summary>
        [ArgumentName("nextBusinessDay")]
        public bool? NextBusinessDay { get; set; }

        /// <summary>
        /// If set to true, indicate strict DCT validation of address details, and validation of product and service(s) combination provided in request.
        /// </summary>
        [ArgumentName("strictValidation")]
        public bool? StrictValidation { get; set; }

        /// <summary>
        /// Option to return list of all value added services and its rule groups if applicable
        /// </summary>
        [ArgumentName("getAllValueAddedServices")]
        public bool? GetAllValueAddedServices { get; set; }

        /// <summary>
        /// Option to return Estimated Delivery Date in response
        /// </summary>
        [ArgumentName("requestEstimatedDeliveryDate")]
        public bool? RequestEstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Estimated Delivery Date Type. QDDF: is the fastest 'docs' transit time as quoted to the customer at booking or shipment creation. No custom clearance is considered. 
        /// </summary>
        [ArgumentName("estimatedDeliveryType")]
        [QueryArgumentConverter<DeliveryTypeQueryArgumentConverter>]
        public DeliveryType? EstimatedDeliveryType { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductAPIArgs() : base()
        {

        }

        #endregion
    }
}
