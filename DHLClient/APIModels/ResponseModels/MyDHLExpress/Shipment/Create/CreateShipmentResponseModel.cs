using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment creation
    /// </summary>
    public class CreateShipmentResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="DispatchConfirmationNumber"/> property
        /// </summary>
        private string? mDispatchConfirmationNumber;

        /// <summary>
        /// The member of the <see cref="Packages"/> property
        /// </summary>
        private IEnumerable<PackageResponseModel>? mPackages;

        /// <summary>
        /// The member of the <see cref="Documents"/> property
        /// </summary>
        private IEnumerable<DocumentResponseModel>? mDocuments;

        #endregion

        #region Public Properties

        /// <summary>
        /// URL where the request has been sent to
        /// </summary>
        [JsonProperty("url")]
        public Uri? URL { get; set; }

        /// <summary>
        /// Here you will receive Shipment Identification Number of your package
        /// </summary>
        [JsonProperty("shipmentTrackingNumber")]
        public int ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// If you requested pickup for your shipment you can use this URL to cancel the pickup
        /// </summary>
        [JsonProperty("cancelPickupUrl")]
        public Uri? CancelPickupURL { get; set; }

        /// <summary>
        /// You can use this URL to track your shipment
        /// </summary>
        [JsonProperty("trackingUrl")]
        public Uri? TrackingURL { get; set; }

        /// <summary>
        /// If you asked for pickup service here you will find Dispatch Confirmation Number which identifies your pickup booking
        /// </summary>
        [JsonProperty("dispatchConfirmationNumber")]
        public string DispatchConfirmationNumber 
        { 
            get => mDispatchConfirmationNumber ?? string.Empty;
            set => mDispatchConfirmationNumber = value;
        }

        /// <summary>
        /// Here you can find information for all pieces your shipment is having like Piece Identification Number
        /// </summary>
        [JsonProperty("packages")]
        public IEnumerable<PackageResponseModel> Packages 
        { 
            get => mPackages ?? Enumerable.Empty<PackageResponseModel>();
            set => mPackages = value;
        }

        /// <summary>
        /// Here you can find all documents created for the shipment like Transport and WaybillDoc labels, Invoice, Receipt
        /// </summary>
        [JsonProperty("documents")]
        public IEnumerable<DocumentResponseModel> Documents 
        { 
            get => mDocuments ?? Enumerable.Empty<DocumentResponseModel>();
            set => mDocuments = value;
        }

        /// <summary>
        /// In this field you will find the On Demand Delivery (ODD) URL link if requested
        /// </summary>
        /// <example>https://odd-test.dhl.com/odd-online/US/wH24aaaaa1</example>
        [JsonProperty("onDemandDeliveryURL")]
        public Uri? OnDemandDelivery { get; set; }

        /// <summary>
        /// Here you can find additional information related to your shipment when you ask for it in the request
        /// </summary>
        [JsonProperty("shipmentDetails")]
        public IEnumerable<CreateShipmentDetailResponseModel> ShipmentDetails { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CreateShipmentResponseModel() : base()
        {

        }

        #endregion
    }
}
