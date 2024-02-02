namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the charge type
    /// </summary>
    public enum TotalChargeType
    {
        /// <summary>
        /// Quoted shipment total discount (STDIS)
        /// </summary>
        QuotedShipmentTotalDiscount = 0,

        /// <summary>
        /// Shipment Customs value (SCUSV)
        /// </summary>
        ShipmentCustomsValue = 1,

        /// <summary>
        /// Shipment Insured value (SINSV)
        /// </summary>
        ShipmentInsuredValue = 2,

        /// <summary>
        /// Shipment product quote discount (SPRQD)
        /// </summary>
        ShipmentQuoteDiscount = 3,

        /// <summary>
        /// The price quoted to the Customer by DHL at the time of the booking.
        /// This quote covers the weight price including discounts and without taxes. (SPRQN)
        /// </summary>
        SPRQN = 4,

        /// <summary>
        /// The total of service charges quoted to customer for DHL Express value added services,
        /// the amount is after discounts and doesn't include tax amounts. (STSCH)
        /// </summary>
        STSCH = 5,

        /// <summary>
        /// The total of service charges as provided by Merchant for the purpose of landed cost calculation. (MACHG)
        /// </summary>
        MACHG = 6,

        /// <summary>
        /// The freight charge as provided by Merchant for the purpose of landed cost calculation. (MFCHG)
        /// </summary>
        MFCHG = 7
    }
}
