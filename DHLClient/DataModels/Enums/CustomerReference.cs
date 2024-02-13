using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the customer references
    /// </summary>
    public enum CustomerReference
    {
        /// <summary>
        /// Shipment reference number of the receiver (AAO)
        /// </summary>
        ShipmentReferenceNumberOfTheReceiver = 0,

        /// <summary>
        /// Reference number of the consignor - default (CU)
        /// </summary>
        ReferenceNumberOfConsignor = 1,

        /// <summary>
        /// Reference number of freight forwarder (FF)
        /// </summary>
        ReferenceNumberOfFreightForwarder = 2,

        /// <summary>
        /// Freight bill number for ex works invoice number (FN)
        /// </summary>
        FreightBillNumber = 3,

        /// <summary>
        /// Inbound center reference number (IBC)
        /// </summary>
        InboundCenterReferenceNumber = 4,

        /// <summary>
        /// Load list reference for 10-digit shipment ID (LLR)
        /// </summary>
        LoadListReference = 5,

        /// <summary>
        /// Outbound reference number for shipment identifier (country of origin) (OBC)
        /// </summary>
        OutboundReferenceNumber = 6,

        /// <summary>
        /// Pickup request number for (booking reference number) (PRN)
        /// </summary>
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