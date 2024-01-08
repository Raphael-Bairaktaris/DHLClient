using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the reference type
    /// </summary>
    public enum ReferenceType
    {
        /// <summary>
        /// Customer reference
        /// </summary>
        CustomerReference = 0,

        /// <summary>
        /// Customer confirmation number
        /// </summary>
        CustomerConfirmationNumber = 1,

        /// <summary>
        /// Local tracking number
        /// </summary>
        LocalTrackingNumber = 2,

        /// <summary>
        /// Ecommerce number
        /// </summary>
        EcommerceNumber = 3,

        /// <summary>
        /// Housebill
        /// </summary>
        Housebill = 4,

        /// <summary>
        /// Masterbill
        /// </summary>
        Masterbill = 5,

        /// <summary>
        /// Container number
        /// </summary>
        ContainerNumber = 6,

        /// <summary>
        /// Shipment Id
        /// </summary>
        ShipmentId = 7,

        /// <summary>
        /// Domestic consignment Id
        /// </summary>
        DomesticConsignmentId = 8,

        /// <summary>
        /// Reference
        /// </summary>
        Reference = 9
    }
}
