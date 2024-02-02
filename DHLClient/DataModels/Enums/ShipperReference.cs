namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the shipper's reference types
    /// </summary>
    public enum ShipperReference
    {
        /// <summary>
        /// Shipment reference number of receiver (AAO)
        /// </summary>
        ShipmentReferenceNumberOfReceiver = 0,

        /// <summary>
        /// Reference number of consignor - default (CU)
        /// </summary>
        ReferenceNumberOfConsignor = 1,

        /// <summary>
        /// Reference number of freight forwarder (FF)
        /// </summary>
        ReferenceNumberOfFreightForwarder = 2,

        /// <summary>
        /// Freight bill number for (FN)
        /// </summary>
        /// <example>Works invoice number</example>
        FreightBillNumber = 3,

        /// <summary>
        /// Inbound center reference number (IBC)
        /// </summary>
        InboundCenterReferenceNumber = 4,

        /// <summary>
        /// Load list reference for <10-digit Shipment ID> (LLR)
        /// </summary>
        LoadListReference = 5,

        /// <summary>
        /// Outbound center reference number for (OBC)
        /// </summary>
        /// <example>SHIPMENT IDENTIFIER (COUNTRY OF ORIGIN)</example>
        OutboundCenterReferenceNumber = 6,

        /// <summary>
        /// Pickup request number for (PRN)
        /// </summary>
        /// <example>BOOKINGREFERENCE NUMBER</example>
        PickupRequestNumber = 7,

        /// <summary>
        /// Local payer account number (ACP)
        /// </summary>
        LocalPayerAccountNumber = 8,

        /// <summary>
        /// Local shipper account number (ACS)
        /// </summary>
        LocalShipperAccountNumber = 9,

        /// <summary>
        /// Local receiver account number (ACR)
        /// </summary>
        LocalReceiverAccountNumber = 10,

        /// <summary>
        /// Customs declaration number (CDN)
        /// </summary>
        CustomsDeclarationNumber = 11,

        /// <summary>
        /// Eurolog 15-digit shipment id (STD)
        /// </summary>
        EurologShipmentId = 12,

        /// <summary>
        /// Buyers order number (CO)
        /// </summary>
        BuyersOrderNumber = 13
    }
}
