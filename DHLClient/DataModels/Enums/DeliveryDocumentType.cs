namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the delivery document types
    /// </summary>
    public enum DeliveryDocumentType
    {
        /// <summary>
        /// Label
        /// </summary>
        Label = 0,

        /// <summary>
        /// Waybill document
        /// </summary>
        WaybillDoc = 1,

        /// <summary>
        /// Invoice
        /// </summary>
        Invoice = 2,

        /// <summary>
        /// QR-code
        /// </summary>
        QRCode = 3,

        /// <summary>
        /// Shipment receipt
        /// </summary>
        ShipmentReceipt = 4
    }
}
