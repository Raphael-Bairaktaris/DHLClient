namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the type code
    /// </summary>
    public enum BreakdownType
    {
        /// <summary>
        /// Total tax for the shipment (STTXA)
        /// </summary>
        TotalTaxForTheShipment = 0,

        /// <summary>
        /// Total discount for the shipment (STDIS)
        /// </summary>
        TotalDiscountForTheShipment = 1,

        /// <summary>
        /// Net shipment / weight charge (SPQRT)
        /// </summary>
        NetShipmentWeightCharge = 2
    }
}
