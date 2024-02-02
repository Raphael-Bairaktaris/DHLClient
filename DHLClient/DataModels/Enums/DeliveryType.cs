namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the delivery types
    /// </summary>
    public enum DeliveryType
    {
        /// <summary>
        /// The fastest ("docs") transit time as quoted to the customer at booking or shipment creation. No custom clearance is considered.
        /// </summary>
        QDDC = 0,

        /// <summary>
        /// Constitutes DHL's service commitment as quoted at booking/shipment creation. QDDc builds in clearance time, 
        /// and potentially other special operational non-transport component(s), when relevant.
        /// </summary>
        QDDF = 1,
    }
}
