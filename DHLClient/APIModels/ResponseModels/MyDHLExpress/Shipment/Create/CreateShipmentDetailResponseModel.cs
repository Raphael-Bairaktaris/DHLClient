using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represent shipment details
    /// </summary>
    public class CreateShipmentDetailResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ServiceHandlingFeatureCodes"/> property
        /// </summary>
        private IEnumerable<string>? mServiceHandlingFeatureCodes;

        /// <summary>
        /// The member of the <see cref="BillingCode"/> property
        /// </summary>
        private string? mBillingCode;

        /// <summary>
        /// The member of the <see cref="ServiceContentCode"/> property
        /// </summary>
        private string? mServiceContentCode;

        /// <summary>
        /// The member of the <see cref="CustomerDetails"/> property
        /// </summary>
        private ShippingCustomerDetailResponseModel? mCustomerDetails;

        /// <summary>
        /// The member of the <see cref="OriginServiceArea"/> property
        /// </summary>
        private ShipmentRouteResponseModel? mOriginServiceArea;

        /// <summary>
        /// The member of the <see cref="DestinationServiceArea"/> property
        /// </summary>
        private ShipmentRouteResponseModel? mDestinationServiceArea;

        /// <summary>
        /// The member of the <see cref="DHLRoutingCode"/> property
        /// </summary>
        private string? mDHLRoutingCode;

        /// <summary>
        /// The member of the <see cref="DHLRoutingDataId"/> property
        /// </summary>
        private string? mDHLRoutingDataId;

        /// <summary>
        /// The member of the <see cref="DeliveryDateCode"/> property
        /// </summary>
        private string? mDeliveryDateCode;

        /// <summary>
        /// The member of the <see cref="DeliveryTimeCode"/> property
        /// </summary>
        private string? mDeliveryTimeCode;

        /// <summary>
        /// The member of the <see cref="ProductShortName"/> property
        /// </summary>
        private string? mProductShortName;

        /// <summary>
        /// The member of the <see cref="ValueAddedService"/> property
        /// </summary>
        private IEnumerable<ValueAddedServiceResponseModel>? mValueAddedService;

        #endregion

        #region Public Properties

        /// <summary>
        /// This array contains all the DHL Express special handling feature codes
        /// </summary>
        [JsonProperty("serviceHandlingFeatureCodes")]
        public IEnumerable<string> ServiceHandlingFeatureCodes 
        { 
            get => mServiceHandlingFeatureCodes ?? Enumerable.Empty<string>();
            set => mServiceHandlingFeatureCodes = value;
        }

        /// <summary>
        /// Here you can find calculated volumetric weight based on dimensions provided in the request
        /// </summary>
        /// <example>245.56</example>
        [JsonProperty("volumetricWeight")]
        public double VolumetricWeight { get; set; }

        /// <summary>
        /// Here you can find billing code which was applied on your shipment
        /// </summary>
        /// <example>IMP</example>
        [JsonProperty("billingCode")]
        public string BillingCode 
        { 
            get => mBillingCode ?? string.Empty;
            set => mBillingCode = value;
        }

        /// <summary>
        /// Here you can find the DHL Express shipment content code of your shipment
        /// </summary>
        /// <example>WPX</example>
        [JsonProperty("serviceContentCode")]
        public string ServiceContentCode 
        { 
            get => mServiceContentCode ?? string.Empty;
            set => mServiceContentCode = value;
        }

        /// <summary>
        /// Here you need to define all the parties needed to ship the package
        /// </summary>
        [JsonProperty("customerDetails")]
        public ShippingCustomerDetailResponseModel CustomerDetails 
        { 
            get => mCustomerDetails ??= new ShippingCustomerDetailResponseModel();
            set => mCustomerDetails = value;
        }

        /// <summary>
        /// The origin service area
        /// </summary>
        [JsonProperty("originServiceArea")]
        public ShipmentRouteResponseModel OriginServiceArea 
        { 
            get => mOriginServiceArea ??= new ShipmentRouteResponseModel();
            set => mOriginServiceArea = value;
        }

        /// <summary>
        /// The destination service area
        /// </summary>
        [JsonProperty("destinationServiceArea")]
        public ShipmentRouteResponseModel DestinationServiceArea 
        { 
            get => mDestinationServiceArea ??= new ShipmentRouteResponseModel();
            set => mDestinationServiceArea = value;
        }

        /// <summary>
        /// Here you can find DHL Routing Code which was applied on your shipment
        /// </summary>
        [JsonProperty("dhlRoutingCode")]
        public string DHLRoutingCode 
        { 
            get => mDHLRoutingCode ?? string.Empty;
            set => mDHLRoutingCode = value;
        }

        /// <summary>
        /// Here you can find DHL Routing Data ID which was applied on your shipment
        /// </summary>
        [JsonProperty("dhlRoutingDataId")]
        public string DHLRoutingDataId 
        { 
            get => mDHLRoutingDataId ?? string.Empty;
            set => mDHLRoutingDataId = value;
        }

        /// <summary>
        /// Here you can find Delivery Date Code which was applied on your shipment
        /// </summary>
        [JsonProperty("deliveryDateCode")]
        public string DeliveryDateCode 
        { 
            get => mDeliveryDateCode ?? string.Empty;
            set => mDeliveryDateCode = value;
        }

        /// <summary>
        /// Here you can find Delivery Time Code which was applied on your shipment
        /// </summary>
        [JsonProperty("deliveryTimeCode")]
        public string DeliveryTimeCode 
        { 
            get => mDeliveryTimeCode ?? string.Empty;
            set => mDeliveryTimeCode = value;
        }

        /// <summary>
        /// Here you can find the product short name of your shipment
        /// </summary>
        [JsonProperty("productShortName")]
        public string ProductShortName 
        { 
            get => mProductShortName ?? string.Empty;
            set => mProductShortName = value;
        }

        /// <summary>
        /// The value added services
        /// </summary>
        [JsonProperty("valueAddedService")]
        public IEnumerable<ValueAddedServiceResponseModel> ValueAddedService 
        { 
            get => mValueAddedService ?? Enumerable.Empty<ValueAddedServiceResponseModel>();
            set => mValueAddedService = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CreateShipmentDetailResponseModel() : base()
        {

        }

        #endregion
    }
}