namespace DHLClient
{
    /// <summary>
    /// The arguments used for uploading an invoice
    /// </summary>
    public class UploadCommercialInvoiceAPIArgs : BaseMyDHLAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// DHL Express shipment identification number
        /// </summary>
        [ArgumentName("shipmentTrackingNumber")]
        public int ShipmentTrackingNumber { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UploadCommercialInvoiceAPIArgs() : base()
        {

        }

        #endregion
    }
}
