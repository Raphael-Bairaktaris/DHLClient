namespace DHLClient.DataModels.Enums
{
    /// <summary>
    /// Provides enumeration over the shipper's reference types
    /// </summary>
    public enum ShipperReference
    {
        /// <summary>
        /// Shipment reference number of receiver
        /// </summary>
        AAO = 0,

        /// <summary>
        /// Reference number of consignor - default
        /// </summary>
        CU = 1,

        /// <summary>
        /// Reference number of freight forwarder
        /// </summary>
        FF = 2,

        /// <summary>
        /// Freight bill number for
        /// </summary>
        /// <example>Works invoice number</example>
        FN = 3,

        /// <summary>
        /// Inbound center reference number
        /// </summary>
        IBC = 4,

        /// <summary>
        /// Load list reference for <10-digit Shipment ID>
        /// </summary>
        LLR = 5,

        /// <summary>
        /// Outbound center reference number for <example>SHIPMENT IDENTIFIER (COUNTRY OF ORIGIN)</example>
        /// </summary>
        OBC = 6,

        /// <summary>
        /// Pickup request number for <example>BOOKINGREFERENCE NUMBER</example>
        /// </summary>
        PRN = 7,

        /// <summary>
        /// Local payer account number
        /// </summary>
        ACP = 8,

        /// <summary>
        /// Local shipper account number
        /// </summary>
        ACS = 9,

        /// <summary>
        /// Local receiver account number
        /// </summary>
        ACR = 10,

        /// <summary>
        /// Customs declaration number
        /// </summary>
        CDN = 11,

        /// <summary>
        /// Eurolog 15-digit shipment id
        /// </summary>
        STD = 12,

        /// <summary>
        /// Buyers order number
        /// </summary>
        CO = 13
    }
}
