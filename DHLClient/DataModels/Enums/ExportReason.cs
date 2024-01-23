using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the export reasons
    /// </summary>
    public enum ExportReason
    {
        /// <summary>
        /// Permanent
        /// </summary>
        Permanent = 0,

        /// <summary>
        /// Temporary
        /// </summary>
        Temporary = 1,

        /// <summary>
        /// Return
        /// </summary>
        Return = 2,

        /// <summary>
        /// Used exhibition goods to origin
        /// </summary>
        UsedExhibitionGoodsToOrigin = 3,

        /// <summary>
        /// Intercompany use
        /// </summary>
        IntercompanyUse = 4,

        /// <summary>
        /// Commercial purpose or sale
        /// </summary>
        CommercialPurposeOrSale = 5,

        /// <summary>
        /// Personal belongings or personal use
        /// </summary>
        PersonalBelongingsOrPersonalUse = 6,

        /// <summary>
        /// Sample
        /// </summary>
        Sample = 7,

        /// <summary>
        /// Gift
        /// </summary>
        Gift = 8,

        /// <summary>
        /// Return to origin
        /// </summary>
        ReturnToOrigin = 9,

        /// <summary>
        /// Warranty replacement
        /// </summary>
        WarrantyReplacement = 10,

        /// <summary>
        /// Diplomatic goods
        /// </summary>
        DiplomaticGoods = 11,

        /// <summary>
        /// Defence material
        /// </summary>
        DefenceMaterial = 12
    }
}
