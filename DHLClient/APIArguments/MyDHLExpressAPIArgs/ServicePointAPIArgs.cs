using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Arguments used for service point
    /// </summary>
    public class ServicePointAPIArgs : BaseMyDHLAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// The address near which Service Points are to be found. If servicePointID is used, address is not needed.
        /// Address can be sent as raw address.However to be GDPR compliant, tokenized address in request should be sent.
        /// </summary>
        /// <example>VGP Victory House, Shop no 6 , 6A, CHENNAI, Tamil Nadu</example>
        [ArgumentName("address")]
        public string? Address { get; set; }

        /// <summary>
        /// To specify the placeID for which the nearest service points have to be searched. 
        /// PlaceId refers to the ID provided by any provider for particular Address.
        /// </summary>
        /// <example>Google</example>
        [ArgumentName("placeId")]
        public string? PlaceId { get; set; }

        /// <summary>
        /// To specify the providerId(provider) for the place ID
        /// </summary>
        [ArgumentName("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// The geographical coordinates of a user's location
        /// If address / ServicePointId parameter is used then this parameter is not needed
        /// </summary>
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Service Point ID is a unique key with 6 characters, consisting of Service Area for first 3 characters
        /// and the last 3 characters is the Facility code
        /// </summary>
        /// <example>Service point ID = BRU001.</example>
        [ArgumentName("servicePointId")]
        public string? ServicePointId { get; set; }

        /// <summary>
        /// Only ISO 3166-1 - Alpha-2 for country code can be used,  
        /// This country code is used for returning matching service points in that country.
        /// </summary>
        /// <example>“NL”, “ES”, “GB”, “US”, “DE”</example>
        /// <summary>
        /// When rendering the service point information, the time format (24h or AM/PM), and 
        /// distance unit (km/miles) are derived from the country information stored in the GSPL database for the country specified via this parameter.
        /// </summary>
        /// <example> for countryCode=GB will be time format AM/PM and distance unit will be mi.</example>
        [ArgumentName("countryCode")]
        public CountryCode? CountryCode { get; set; }

        /// <summary>
        /// Language Code - represents the language. Mandatory if Script Code is provided or Language Country Code is provided, else optional.
        /// </summary>
        /// <example>‘eng’</example>
        [ArgumentName("languageCode")]
        public LanguageCode? LanguageCode { get; set; }

        /// <summary>
        /// Language Script Code - represents the writing system. Mandatory if Language Country Code is provided, else optional.
        /// </summary>
        [ArgumentName("languageScriptCode")]
        public string? LanguageScriptCode { get; set; }

        /// <summary>
        /// Max. number of service points to be returned.
        /// If id or idf is used, this parameter is not needed as this will return searched service point.
        /// </summary>
        /// <example>10</example>
        [ArgumentName("servicePointResults")]
        public double? ServicePointResults { get; set; }

        /// <summary>
        /// Comma separated list of physical process capability codes.
        /// <list type="table|bullet|number">
        ///     <item>81: I have a DHL account or return shipment</item>
        ///     <item>82: I have paid online</item>
        ///     <item>88: I will pay at the DHL Service Point</item>
        ///     <item>73: I will create a DHL shipping label at the DHL Service Point</item>
        ///     <item>74: I have printed a DHL label</item>
        ///     <item>75,76: I have a QR code</item>
        ///     <item>78,79: Im collecting a DHL Express parcel</item>
        ///     <item>86,87: I have directed a DHL Express parcel to a DHL Service Point</item>
        /// </list>
        /// Possible Combinations : 81,73 | 81,74 | 81,75,76 | 82,74 | 82,75,76 | 88,73 | 78,79 | 86,87
        /// NOTE: | is just used to represent the separation of combinations.
        /// </summary>
        /// <example>86,87</example>
        [ArgumentName("capability")]
        public string? Capability { get; set; }

        /// <summary>
        /// Service points open Before given Time. 
        /// </summary>
        /// <example>14:00 will find service points which are open before 14:00</example>
        [ArgumentName("openBefore")]
        public TimeOnly? OpenBefore { get; set; }

        /// <summary>
        /// Service points open After given time
        /// </summary>
        /// <example>15:00 will find service points which are open after 15:00</example>
        [ArgumentName("openAfter")]
        public TimeOnly? OpenAfter { get; set; }

        /// <summary>
        /// Open on Weekday, valid values as follow: 1, 2, 3, 4, 5, 6, 0
        /// Where 1 applies for Monday and 0 applies for Sunday
        /// </summary>
        [ArgumentName("openDay")]
        public DayOfWeek? OpenDay { get; set; }

        /// <summary>
        /// Max. weight of the shipment. Decimals are allowed as well (decimal separator either “,” or “.”
        /// </summary>
        [ArgumentName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Weight units – kg or lb. Required if weight is passed in.
        /// </summary>
        /// <example>kg</example>
        [ArgumentName("weightUom")]
        public WeightUnit? WeightUom { get; set; }

        /// <summary>
        /// Distance uom to be used when returning response, it can be either km or mi. If not provided, default uom set for the country is returned.
        /// </summary>
        /// <example>Mi</example>
        [ArgumentName("resultUom")]
        public DistanceUnit? ResultUom { get; set; }

        /// <summary>
        /// Service Area Code of the search address
        /// </summary>
        /// <example>MAA</example>
        [ArgumentName("serviceAreaCode")]
        public string? ServiceAreaCode { get; set; }

        /// <summary>
        /// Comma separated list of service point types
        /// </summary>
        /// <example>CTY,STN,247</example>
        [ArgumentName("servicePointTypes")]
        public ServicePoint? ServicePointTypes { get; set; }

        /// <summary>
        /// Maximum distance in kilometers between the geocoded address and the returned Service Points. 
        /// Values equal or less than 0 are ignored.
        /// </summary>
        /// <example>50</example>
        [ArgumentName("maxDistance")]
        public double? MaxDistance { get; set; }

        /// <summary>
        /// Y/N – indicator whether it is possible to pay import charges on service point.
        /// </summary>
        [ArgumentName("importCharges")]
        public IEnumerable<bool>? ImportChrges { get; set; }

        /// <summary>
        /// Unique API key which required separate onboarding request to enable this service. 
        /// Please approach your country representative for onboarding. 
        /// Once approval is granted, API key will be generated and used for authentication.
        /// </summary>
        /// <example>85fg600e-be39-4ef0-ac47-23ghj4756948g</example>
        [ArgumentName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Allows combination of values for parameters servicePointTypes and importChanges. 
        /// Limitations:- Only 1 level of conditions is allowed (not multiple AND/OR)Applicable only on servicePointTypes and importCharges parameters 
        /// “,” stands for OR condition “&” stands for AND condition “()” splits multiple conditions.
        /// </summary>
        /// <example>(servicePointTypes=STN,CTY),(servicePointTypes=PRT,247&importCharges=true)</example>
        [ArgumentName("combineParameters")]
        public string? CombineParameters { get; set; }

        /// <summary>
        /// Parameter which will enable to filter out fully booked services in the Service Point Locator response to client.
        /// Y - Service Point Locator will not send back service points which are fully booked.
        /// N - Service Point Locator will send back all service points, also those where is no free capacity.
        /// If not provided in request, it will be set up as N by default.
        /// This is a Servicepoint Capacity Management System parameter.
        /// </summary>
        [ArgumentName("excludeFullyBooked")]
        public IEnumerable<bool>? ExcludeFullyBooked { get; set; }

        /// <summary>
        /// To specify the shipment ID. This is used for Servicepoint Capacity Management System parameter.
        /// </summary>
        /// <example>6360778572</example>
        [ArgumentName("shipmentID")]
        public double? ShipmentId { get; set; }

        /// <summary>
        /// Piece ID without Data Identifier / Prefix. 
        /// </summary>
        /// <example>JD0081105201831337270 instead of JJD0081105201831337270</example>
        [ArgumentName("pieceId")]
        public string? PieceId { get; set; }

        /// <summary>
        /// To specify the Shipment Origin Service Area Code. 
        /// This is a Servicepoint Capacity Management System parameter.
        /// </summary>
        [ArgumentName("shipmentOriginServiceAreaCode")]
        public string? ShipmentOriginServiceAreaCode { get; set; }

        /// <summary>
        /// This is to include preconfigured non UI capability codes(ex. PPC 72) to be considered while sending 
        /// the request to Reference Data backend service. PPC 72 is applicable only for REST request and not for Service Point Locator UI.
        /// </summary>
        [ArgumentName("isResultsSpecificCapabRequired")]
        public IEnumerable<bool>? IsResultsSpecificCapabRequired { get; set; }

        /// <summary>
        /// This 'encrypt' flag is to indicate to Service Point Locator whether the address is tokenized(encrypt=y) or non-tokenized. 
        /// So that Service Point Locator can detokenize to provide matching Service Point list.
        /// When 'encrypt=y', Service Point Locator clients should mandatorily send tokenized address in the REST request.
        /// When 'encrypt=n' or without 'encrypt' parameter, client should only send non-tokenized address(raw address).
        /// NOTE: Address Tokenization: Service Point Locator provides additional security to mask the address sent by the client
        /// in REST request which will hide raw address visible on the ‘View page Source’ or in ‘Developer tools.
        /// </summary>
        [ArgumentName("encrypt")]
        public IEnumerable<bool>? Encrypt { get; set; }

        /// <summary>
        /// This indicates whether the address parameter contains the base64 encoded value or not.
        /// </summary>
        [ArgumentName("b64")]
        public IEnumerable<bool>? Base64 { get; set; }

        /// <summary>
        /// ServicePoint Status(svpStatus) to be used especially when looking for inactive service points with the svpStatus S,U,X,Y.
        /// By default active svpStatus 'A' is considered when this parameter is not sent in the request.
        /// </summary>
        [ArgumentName("svpStatus")]
        public ServicePointStatus? SvpStatus { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointAPIArgs() : base()
        {

        }

        #endregion
    }
}
