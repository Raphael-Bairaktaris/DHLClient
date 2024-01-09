using DHLClient.DataModels.Enums;
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
        /// Maps the <see cref="LocationType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<LocationType, string> LocationTypeToStringMapper { get; } = new Dictionary<LocationType, string>()
        {
            { LocationType.ServicePoint, "servicepoint" },
            { LocationType.Locker, "locker" },
            { LocationType.PostOffice, "postoffice" },
            { LocationType.PostBank, "postbank" },
            { LocationType.POBox, "pobox" }
        }.ToImmutableDictionary();

        public static IReadOnlyDictionary<ProviderType, string> ProviderTypeToStringMapper { get; } = new Dictionary<ProviderType, string>()
        {
            { ProviderType.Express, "express" },
            { ProviderType.Parcel, "parcel" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ServiceType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ServiceType, string> ServiceTypeToStringMapper { get; } = new Dictionary<ServiceType, string>()
        {
            { ServiceType.ParcelPickup, "parcel:pick-up" },
            { ServiceType.ParcelDropOff, "parcel:drop-off" },
            { ServiceType.ExpressPickup, "express:pick-up" },
            { ServiceType.ExpressDropOff, "express:drop-off" },
            { ServiceType.ExpressDropOffAccount, "express:drop-off-account" },
            { ServiceType.ExpressDropOffEasy, "express:drop-off-easy" },
            { ServiceType.ExpressDropOffPrelabeled, "express:drop-off-prelabeled" },
            { ServiceType.ParcelPickupRegistered, "parcel:pickup-registered" },
            { ServiceType.ParcelPickupUnregistered, "parcel:pickup-unregistered" },
            { ServiceType.ParcelDropOffUnregistered, "parcel:drop-off-unregistered" },
            { ServiceType.LetterService, "letter-service" },
            { ServiceType.Postbank, "postbank" },
            { ServiceType.CashOnDelivery, "cash-on-delivery" },
            { ServiceType.Franking, "franking" },
            { ServiceType.CashService, "cash-service" },
            { ServiceType.PackagingMaterial, "packaging-material" },
            { ServiceType.Postident, "postident" },
            { ServiceType.AgeVerification, "age-verification" },
            { ServiceType.HandicappedAccess, "handicapped-access" },
            { ServiceType.Parking, "parking" },
            { ServiceType.ParcelDropOffUnlabeled, "parcel:drop-off-unlabeled" },
            { ServiceType.ExpressDropOffUnlabeled, "express:drop-off-unlabeled" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="DestinationProvider"/> to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<DestinationProvider, string> DestinationProviderTypeToStringMapper { get; } = new Dictionary<DestinationProvider, string>()
        {
            { DestinationProvider.Oepag, "oepag" },
            { DestinationProvider.Express, "express" },
            { DestinationProvider.ParcelBl, "parcel-bl" },
            { DestinationProvider.Bpost, "bpost" },
            { DestinationProvider.Rapido, "rapido" },
            { DestinationProvider.ACSCourier, "acs-courier" },
            { DestinationProvider.ParcelCZ, "parcel-cz" },
            { DestinationProvider.Freight, "freight" },
            { DestinationProvider.ParcelDE, "parcel-de" },
            { DestinationProvider.TransOFlex, "trans-o-flex" },
            { DestinationProvider.Bring, "bring" },
            { DestinationProvider.ParcelES, "parcel-es" },
            { DestinationProvider.RelaisColis, "relais-colis" },
            { DestinationProvider.ColisPrive, "colis-prive" },
            { DestinationProvider.FreightFR, "freight-fr" },
            { DestinationProvider.Chronopost, "chronopost" },
            { DestinationProvider.ParcelUK, "parcel-uk" },
            { DestinationProvider.HrvatskaPosta, "hrvatska-posta" },
            { DestinationProvider.MagyarPosta, "magyar-posta" },
            { DestinationProvider.Anpost, "anpost" },
            { DestinationProvider.Fastway, "fastway" },
            { DestinationProvider.ParcelLU, "parcel-lu" },
            { DestinationProvider.ParcelBE, "parcel-be" },
            { DestinationProvider.ParcelNL, "parcel-nl" },
            //{ DestinationProvider.Oepag, "oepag" },
            //{ DestinationProvider.Oepag, "oepag" },
            //{ DestinationProvider.Oepag, "oepag" },
            //{ DestinationProvider.Oepag, "oepag" },
            //{ DestinationProvider.Oepag, "oepag" },
            //{ DestinationProvider.Oepag, "oepag" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="CountryCode"/> to their related <see cref="string"/>
        /// </summary>
        public static IReadOnlyDictionary<CountryCode, string> CountryCodeToStringMapper { get; } = Enum.GetValues<CountryCode>().ToImmutableDictionary(x => x, x => x.ToString().ToLower());

        /// <summary>
        /// Maps the <see cref="LanguageCode"/> to their related <see cref="string"/>
        /// </summary>
        public static IReadOnlyDictionary<LanguageCode, string> LanguageCodeToStringMapper { get; } = Enum.GetValues<LanguageCode>().ToImmutableDictionary(x => x, x => x.ToString().ToLower());
    }
}