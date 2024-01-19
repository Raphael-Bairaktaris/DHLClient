using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the destination invoice types
    /// </summary>
    public enum DocumentInvoiceType
    {
        /// <summary>
        /// Waybill
        /// </summary>
        Waybill = 0,

        /// <summary>
        /// Commercial invoice
        /// </summary>
        CommercialInvoice = 1,

        /// <summary>
        /// Customs entry
        /// </summary>
        CustomsEntry = 2
    }
}
