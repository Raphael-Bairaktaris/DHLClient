namespace DHLClient
{
    /// <summary>
    /// The arguments used for uploading an invoice
    /// </summary>
    public class UploadCommercialInvoiceForShipmentAPIArgs : BaseMyDHLAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// DHL Express shipment identification number
        /// </summary>
        [ArgumentName("shipmentTrackingNumber")]
        public long ShipmentTrackingNumber { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UploadCommercialInvoiceForShipmentAPIArgs() : base()
        {

        }

        #endregion
    }
}
