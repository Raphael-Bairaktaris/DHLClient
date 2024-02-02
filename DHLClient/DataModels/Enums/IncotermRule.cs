namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the incoterm rules
    /// </summary>
    public enum IncotermRule
    {
        /// <summary>
        /// Ex works (EXW) 
        /// </summary>
        ExWorks = 0,

        /// <summary>
        /// Free carrier (FCA)
        /// </summary>
        FreeCarrier = 1,

        /// <summary>
        /// Carriage Paid To (CPT)
        /// </summary>
        CarriagePaidTo = 2,

        /// <summary>
        /// Carriage And Insurance Paid To (CIP)
        /// </summary>
        CarriageAndInsurancePaidTo = 3,

        /// <summary>
        /// Delivered At Place Unloaded (DPU)
        /// </summary>
        DeliveredAtPlaceUnloaded = 4,

        /// <summary>
        /// Delivered At Place (DAP)
        /// </summary>
        DeliveredAtPlace = 5,

        /// <summary>
        /// Delivery Duty Paid (DDP)
        /// </summary>
        DeliveryDutyPaid = 6,

        /// <summary>
        /// Free Alongside Ship (FAS)
        /// </summary>
        FreeAlongsideShip = 7,

        /// <summary>
        /// Free On Board (FOB)
        /// </summary>
        FreeOnBoard = 8,

        /// <summary>
        /// Cost And Freight (CFR)
        /// </summary>
        CostAndFreight = 9,

        /// <summary>
        /// Cost, Insurance and Freight (CIF)
        /// </summary>
        CostInsuranceAndFreight = 10,

        /// <summary>
        /// Delivered At Frontier (DAF)
        /// </summary>
        DeliveredAtFrontier = 11,

        /// <summary>
        /// Delivered At Terminal (DAT)
        /// </summary>
        DeliveredAtTerminal = 12,

        /// <summary>
        /// Delivery Duty Unpaid (DDU)
        /// </summary>
        DeliveryDutyUnpaid = 13,

        /// <summary>
        /// Delivery Ex Quay (Duty Paid) (DEQ)
        /// </summary>
        DeliveryExQuay = 14,

        /// <summary>
        /// Delivered Ex Ship (DES)
        /// </summary>
        DeliveredExShip = 15
    }
}
