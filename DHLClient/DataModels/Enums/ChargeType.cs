namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the charge type
    /// </summary>
    public enum ChargeType
    {
        /// <summary>
        /// Quoted shipment total discount
        /// </summary>
        STDIS = 0,

        /// <summary>
        /// Shipment Customs value
        /// </summary>
        SCUSV = 1,

        /// <summary>
        /// Shipment Insured value
        /// </summary>
        SINSV = 2,

        /// <summary>
        /// Shipment product quote discount
        /// </summary>
        SPRQD = 3,

        /// <summary>
        /// The price quoted to the Customer by DHL at the time of the booking.
        /// This quote covers the weight price including discounts and without taxes.
        /// </summary>
        SPRQN = 4,

        /// <summary>
        /// The total of service charges quoted to customer for DHL Express value added services,
        /// the amount is after discounts and doesn't include tax amounts.
        /// </summary>
        STSCH = 5,

        /// <summary>
        /// The total of service charges as provided by Merchant for the purpose of landed cost calculation.
        /// </summary>
        MACHG = 6,

        /// <summary>
        /// The freight charge as provided by Merchant for the purpose of landed cost calculation.
        /// </summary>
        MFCHG = 7
    }
}
