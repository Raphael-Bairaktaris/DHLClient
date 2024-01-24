using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the incoterm rules
    /// </summary>
    public enum IncotermRule
    {
        /// <summary>
        /// Ex works 
        /// </summary>
        EXW = 0,

        /// <summary>
        /// Free carrier
        /// </summary>
        FCA = 1,

        /// <summary>
        /// Carriage Paid To
        /// </summary>
        CPT = 2,

        /// <summary>
        /// Carriage And Insurance Paid To
        /// </summary>
        CIP = 3,

        /// <summary>
        /// Delivered At Place Unloaded
        /// </summary>
        DPU = 4,

        /// <summary>
        /// Delivered At Place
        /// </summary>
        DAP = 5,

        /// <summary>
        /// Delivery Duty Paid
        /// </summary>
        DDP = 6,

        /// <summary>
        /// Free Alongside Ship
        /// </summary>
        FAS = 7,

        /// <summary>
        /// Free On Board
        /// </summary>
        FOB = 8,

        /// <summary>
        /// Cost And Freight
        /// </summary>
        CFR = 9,

        /// <summary>
        /// Cost, Insurance and Freight
        /// </summary>
        CIF = 10,

        /// <summary>
        /// Delivered At Frontier
        /// </summary>
        DAF = 11,

        /// <summary>
        /// Delivered At Terminal
        /// </summary>
        DAT = 12,

        /// <summary>
        /// Delivery Duty Unpaid
        /// </summary>
        DDU = 13,

        /// <summary>
        /// Delivery Ex Quay (Duty Paid)
        /// </summary>
        DEQ = 14,

        /// <summary>
        /// Delivered Ex Ship
        /// </summary>
        DES = 15
    }
}
