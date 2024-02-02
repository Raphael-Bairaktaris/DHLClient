namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the identifier types
    /// </summary>
    public enum IdentifierType
    {
        /// <summary>
        /// Shipment Id (SID)
        /// </summary>
        ShipmentId = 0,

        /// <summary>
        /// Pid
        /// </summary>
        PID = 1,

        /// <summary>
        /// Advanced shipment of three (3) months (ASID3)
        /// </summary>
        AdvanceShipmentOfThreeMonths = 2,

        /// <summary>
        /// Advanced shipment of six (6) months (ASID6)
        /// </summary>
        AdvanceShipmentOfSixMonths = 3,

        /// <summary>
        /// Advances Shipment of twelve (12) months (ASID12)
        /// </summary>
        AdvanceShipmentOfNineMonths = 4,

        /// <summary>
        /// Advances Shipment of twenty four (24) months (ASID24)
        /// </summary>
        AdvanceShipmentOfTwentyFourMonths = 5,

        /// <summary>
        /// Handling Unit ID (HUID)
        /// </summary>
        HandlingUnitId = 6
    }
}