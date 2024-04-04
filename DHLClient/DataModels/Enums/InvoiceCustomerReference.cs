using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the invoice customer reference
    /// </summary>
    public enum InvoiceCustomerReference
    {
        /// <summary>
        /// Parent shipment id for BBX (ACL)
        /// </summary>
        ParentShipmentId = 0,

        /// <summary>
        /// Customer identifier (CID)
        /// </summary>
        CustomerIdentifier = 1,

        /// <summary>
        /// Contract Number (CN)
        /// </summary>
        ContractNumber = 2,

        /// <summary>
        /// Consignor reference number (CU)
        /// </summary>
        ConsignorReferenceNumber = 3,

        /// <summary>
        /// US export declaration reference Id (ITN)
        /// </summary>
        USExportDeclarationReferenceId = 4,

        /// <summary>
        /// Movement reference number (MRN)
        /// </summary>
        MovementReferenceNumber = 5,

        /// <summary>
        /// Unique reference of a consignment (UCN)
        /// </summary>
        UniqueReferenceOfAConsignment = 6,

        /// <summary>
        /// Order number (OID)
        /// </summary>
        OrderNumber = 7,

        /// <summary>
        /// Purchase order number (PON)
        /// </summary>
        PurchaseOrderNumber = 8,

        /// <summary>
        /// RMA number (RMA)
        /// </summary>
        RMANumber = 9
    }
}
