using System.Collections.Immutable;

namespace DHLClient
{
    /// <summary>
    /// Constants related to the DHL client
    /// </summary>
    public static class DHLClientConstants
    {
        /// <summary>
        /// Maps the <see cref="CapacityType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<CapacityType, string> CapacityTypeToStringMapper { get; set; } = new Dictionary<CapacityType, string>()
        {
            { CapacityType.High, "high" },
            { CapacityType.Low, "low" },
            { CapacityType.VeryLow, "veryLow" },
            { CapacityType.Unknown, "unknown" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ClosurePeriodType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<DayOfWeekType, string> DayOfWeekTypeToStringMapper { get; } = new Dictionary<DayOfWeekType, string>()
        {
            { DayOfWeekType.Monday, "monday" },
            { DayOfWeekType.Tuesday, "tuesday" },
            { DayOfWeekType.Wednesday, "wednesday" },
            { DayOfWeekType.Thursday, "thursday" },
            { DayOfWeekType.Friday, "friday" },
            { DayOfWeekType.Saturday, "saturday" },
            { DayOfWeekType.Sunday, "sunday" },
            { DayOfWeekType.PublicHolidays, "publicHolidays" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ServicePointLocationType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ServicePointLocationType, string> ServicePointLocationTypeToStringMapper { get; } = new Dictionary<ServicePointLocationType, string>()
        {
            { ServicePointLocationType.ServicePoint, "servicePoint" },
            { ServicePointLocationType.Locker, "locker" },
            { ServicePointLocationType.PostOffice, "postOffice" },
            { ServicePointLocationType.PostBank, "postBank" },
            { ServicePointLocationType.POBox, "poBox" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ServiceType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ServiceType, string> ServiceTypeToStringMapper { get; } = new Dictionary<ServiceType, string>()
        {
            { ServiceType.ParcelPickUp }
        }.ToImmutableDictionary();
    }
}
