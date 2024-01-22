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
        public static IReadOnlyDictionary<DHLDayOfWeek, string> DayOfWeekTypeToStringMapper { get; } = new Dictionary<DHLDayOfWeek, string>()
        {
            { DHLDayOfWeek.Monday, "monday" },
            { DHLDayOfWeek.Tuesday, "tuesday" },
            { DHLDayOfWeek.Wednesday, "wednesday" },
            { DHLDayOfWeek.Thursday, "thursday" },
            { DHLDayOfWeek.Friday, "friday" },
            { DHLDayOfWeek.Saturday, "saturday" },
            { DHLDayOfWeek.Sunday, "sunday" },
            { DHLDayOfWeek.PublicHolidays, "publicHolidays" }
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

        /// <summary>
        /// Maps the <see cref="ProviderType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ProviderType, string> ProviderTypeToStringMapper { get; } = new Dictionary<ProviderType, string>()
        {
            { ProviderType.Express, "express" },
            { ProviderType.Parcel, "parcel" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ReferenceType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ReferenceType, string> ReferenceTypeToStringMapper { get; } = new Dictionary<ReferenceType, string>()
        {
            { ReferenceType.CustomerReference, "customer-reference" },
            { ReferenceType.CustomerConfirmationNumber, "customer-confirmation-number" },
            { ReferenceType.LocalTrackingNumber, "local-tracking-number" },
            { ReferenceType.EcommerceNumber, "ecommerce-number" },
            { ReferenceType.Housebill, "housebill" },
            { ReferenceType.Masterbill, "masterbill" },
            { ReferenceType.ContainerNumber, "container-number" },
            { ReferenceType.ShipmentId, "shipment-id" },
            { ReferenceType.DomesticConsignmentId, "domestic-cosignment-id" },
            { ReferenceType.Reference, "reference" }
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
        /// Maps the <see cref="ShipmentServiceType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ShipmentServiceType, string> ShipmentServiceTypeToStringMapper { get; } = new Dictionary<ShipmentServiceType, string>()
        {
            { ShipmentServiceType.Freight, "freight" },
            { ShipmentServiceType.Express, "express" },
            { ShipmentServiceType.PostDE, "post-de" },
            { ShipmentServiceType.ParcelDE, "parcel-de" },
            { ShipmentServiceType.ParcelNL, "parcel-nl" },
            { ShipmentServiceType.ParcelPL, "parcel-pl" },
            { ShipmentServiceType.ParcelUK, "parcel-uk" },
            { ShipmentServiceType.DSC, "dsc" },
            { ShipmentServiceType.DGF, "dgf" },
            { ShipmentServiceType.Ecommerce, "ecommerce" },
            { ShipmentServiceType.EcommerceEurope, "ecommerce-europe" },
            { ShipmentServiceType.SVB, "svb" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="StatusCodeType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<StatusCodeType, string> StatusCodeTypeToStringMapper { get; } = new Dictionary<StatusCodeType, string>()
        {
            { StatusCodeType.PreTransit, "pre-transit" },
            { StatusCodeType.Transit, "transit" },
            { StatusCodeType.Delivered, "delivered" },
            { StatusCodeType.Failure, "failure" },
            { StatusCodeType.Unknown, "unknown" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="DestinationProvider"/> to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<DestinationProvider, string> DestinationProviderToStringMapper { get; } = new Dictionary<DestinationProvider, string>()
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
            { DestinationProvider.Posta, "posta" },
            { DestinationProvider.SlovakParcelService, "slovak-parcel-service" },
            { DestinationProvider.ParcelPL, "parcel-pl" },
            { DestinationProvider.ParcelPT, "parcel-pt" },
            { DestinationProvider.UrgentCargus, "urgent-cargus" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="CountryCode"/> to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<CountryCode, string> CountryCodeToStringMapper { get; } = Enum.GetValues<CountryCode>().ToImmutableDictionary(x => x, x => x.ToString().ToLower());

        /// <summary>
        /// Maps the <see cref="LanguageCode"/> to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<LanguageCode, string> LanguageCodeToStringMapper { get; } = Enum.GetValues<LanguageCode>().ToImmutableDictionary(x => x, x => x.ToString().ToLower());

        public static IReadOnlyDictionary<ThreeLetterLanguageCode, string> ThreeLetterLanguageCodeToStringMapper { get; } = new Dictionary<ThreeLetterLanguageCode, string>()
        {
            { ThreeLetterLanguageCode.Afrikaans, "afr" },
            { ThreeLetterLanguageCode.Albanian, "alb" },
            { ThreeLetterLanguageCode.Amharic, "amh" },
            { ThreeLetterLanguageCode.Arabic, "ara" },
            { ThreeLetterLanguageCode.Armenian, "arm" },
            { ThreeLetterLanguageCode.Azerbaijani, "aze" },
            { ThreeLetterLanguageCode.Bengali, "ben" },
            { ThreeLetterLanguageCode.Bosnian, "bos" },
            { ThreeLetterLanguageCode.Bulgarian, "bul" },
            { ThreeLetterLanguageCode.Burmese, "bur" },
            { ThreeLetterLanguageCode.Catalan, "cat" },
            { ThreeLetterLanguageCode.Chinese, "chi" },
            { ThreeLetterLanguageCode.Croatian, "hrv" },
            { ThreeLetterLanguageCode.Czech, "ces" },
            { ThreeLetterLanguageCode.Danish, "dan" },
            { ThreeLetterLanguageCode.Dutch, "dut" },
            { ThreeLetterLanguageCode.English, "eng" },
            { ThreeLetterLanguageCode.Esperanto, "epo" },
            { ThreeLetterLanguageCode.Estonian, "est" },
            { ThreeLetterLanguageCode.Filipino, "fil" },
            { ThreeLetterLanguageCode.Finnish, "fin" },
            { ThreeLetterLanguageCode.French, "fre" },
            { ThreeLetterLanguageCode.Georgian, "geo" },
            { ThreeLetterLanguageCode.German, "ger" },
            { ThreeLetterLanguageCode.Greek, "gre" },
            { ThreeLetterLanguageCode.Gujarati, "guj" },
            { ThreeLetterLanguageCode.Hebrew, "heb" },
            { ThreeLetterLanguageCode.Hindi, "hin" },
            { ThreeLetterLanguageCode.Hungarian, "hun" },
            { ThreeLetterLanguageCode.Icelandic, "ice" },
            { ThreeLetterLanguageCode.Indonesian, "ind" },
            { ThreeLetterLanguageCode.Irish, "gle" },
            { ThreeLetterLanguageCode.Italian, "ita" },
            { ThreeLetterLanguageCode.Japanese, "jpn" },
            { ThreeLetterLanguageCode.Kannada, "kan" },
            { ThreeLetterLanguageCode.Korean, "kor" },
            { ThreeLetterLanguageCode.Latin, "lat" },
            { ThreeLetterLanguageCode.Latvian, "lav" },
            { ThreeLetterLanguageCode.Lithuanian, "lit" },
            { ThreeLetterLanguageCode.Macedonian, "mac" },
            { ThreeLetterLanguageCode.Malay, "may" },
            { ThreeLetterLanguageCode.Maltese, "mlt" },
            { ThreeLetterLanguageCode.Marathi, "mar" },
            { ThreeLetterLanguageCode.Nepali, "nep" },
            { ThreeLetterLanguageCode.Norwegian, "nor" },
            { ThreeLetterLanguageCode.Persian, "per" },
            { ThreeLetterLanguageCode.Polish, "pol" },
            { ThreeLetterLanguageCode.Portuguese, "por" },
            { ThreeLetterLanguageCode.Punjabi, "pan" },
            { ThreeLetterLanguageCode.Romanian, "rum" },
            { ThreeLetterLanguageCode.Russian, "rus" },
            { ThreeLetterLanguageCode.Serbian, "srp" },
            { ThreeLetterLanguageCode.Sinhalese, "sin" },
            { ThreeLetterLanguageCode.Slovak, "slk" },
            { ThreeLetterLanguageCode.Slovenian, "slv" },
            { ThreeLetterLanguageCode.Spanish, "spa" },
            { ThreeLetterLanguageCode.Swahili, "swa" },
            { ThreeLetterLanguageCode.Swedish, "swe" },
            { ThreeLetterLanguageCode.Tamil, "tam" },
            { ThreeLetterLanguageCode.Telugu, "tel" },
            { ThreeLetterLanguageCode.Thai, "tha" },
            { ThreeLetterLanguageCode.Turkish, "tur" },
            { ThreeLetterLanguageCode.Ukrainian, "ukr" },
            { ThreeLetterLanguageCode.Urdu, "urd" },
            { ThreeLetterLanguageCode.Vietnamese, "vie" },
            { ThreeLetterLanguageCode.Welsh, "wel" },
            { ThreeLetterLanguageCode.Xhosa, "xho" },
            { ThreeLetterLanguageCode.Yiddish, "yid" },
            { ThreeLetterLanguageCode.Zulu, "zul" }
    }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="CountryCode"/> to their related country name <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<CountryCode, string> CountryCodeToCountryNameMapper { get; } = new Dictionary<CountryCode, string>()
        {
            { CountryCode.AD, "Andorra" },
            { CountryCode.AE, "United Arab Emirates" },
            { CountryCode.AF, "Afghanistan" },
            { CountryCode.AG, "Antigua And Barbuda" },
            { CountryCode.AI, "Anguilla" },
            { CountryCode.AL, "Albania" },
            { CountryCode.AM, "Armenia" },
            { CountryCode.AN, "Netherlands Antilles" },
            { CountryCode.AO, "Angola" },
            { CountryCode.AQ, "Antarctica" },
            { CountryCode.AR, "Argentina" },
            { CountryCode.AS, "American Samoa" },
            { CountryCode.AT, "Austria" },
            { CountryCode.AU, "Australia" },
            { CountryCode.AW, "Aruba" },
            { CountryCode.AX, "Aland Islands" },
            { CountryCode.AZ, "Azerbaijan" },
            { CountryCode.BA, "Bosnia And Herzegovina" },
            { CountryCode.BB, "Barbados" },
            { CountryCode.BD, "Bangladesh" },
            { CountryCode.BE, "Belgium" },
            { CountryCode.BF, "Burkina Faso" },
            { CountryCode.BG, "Bulgaria" },
            { CountryCode.BH, "Bahrain" },
            { CountryCode.BI, "Burundi" },
            { CountryCode.BJ, "Benin" },
            { CountryCode.BL, "Saint Barthelemy" },
            { CountryCode.BM, "Bermuda" },
            { CountryCode.BN, "Brunei" },
            { CountryCode.BO, "Bolivia" },
            { CountryCode.BR, "Brazil" },
            { CountryCode.BS, "Bahamas" },
            { CountryCode.BT, "Bhutan" },
            { CountryCode.BV, "Bouvet Island" },
            { CountryCode.BW, "Botswana" },
            { CountryCode.BY, "Belarus" },
            { CountryCode.BZ, "Belize" },
            { CountryCode.CA, "Canada" },
            { CountryCode.CC, "Cocos Islands" },
            { CountryCode.CD, "Democratic Republicofthe Congo" },
            { CountryCode.CF, "Central African Republic" },
            { CountryCode.CG, "Republicofthe Congo" },
            { CountryCode.CH, "Switzerland" },
            { CountryCode.CI, "Ivory Coast" },
            { CountryCode.CK, "Cook Islands" },
            { CountryCode.CL, "Chile" },
            { CountryCode.CM, "Cameroon" },
            { CountryCode.CN, "China" },
            { CountryCode.CO, "Colombia" },
            { CountryCode.CR, "Costa Rica" },
            { CountryCode.CU, "Cuba" },
            { CountryCode.CV, "Cape Verde" },
            { CountryCode.CX, "Christmas Island" },
            { CountryCode.CY, "Cyprus" },
            { CountryCode.CZ, "Czech Republic" },
            { CountryCode.DE, "Germany" },
            { CountryCode.DJ, "Djibouti" },
            { CountryCode.DK, "Denmark" },
            { CountryCode.DM, "Dominica" },
            { CountryCode.DO, "Dominican Republic" },
            { CountryCode.DZ, "Algeria" },
            { CountryCode.EC, "Ecuador" },
            { CountryCode.EE, "Estonia" },
            { CountryCode.EG, "Egypt" },
            { CountryCode.EH, "Western Sahara" },
            { CountryCode.ER, "Eritrea" },
            { CountryCode.ES, "Spain" },
            { CountryCode.ET, "Ethiopia" },
            { CountryCode.FI, "Finland" },
            { CountryCode.FJ, "Fiji" },
            { CountryCode.FK, "Falkland Islands" },
            { CountryCode.FM, "Micronesia" },
            { CountryCode.FO, "Faroe Islands" },
            { CountryCode.FR, "France" },
            { CountryCode.GA, "Gabon" },
            { CountryCode.GB, "United Kingdom" },
            { CountryCode.GD, "Grenada" },
            { CountryCode.GE, "Georgia" },
            { CountryCode.GF, "French Guiana" },
            { CountryCode.GG, "Guernsey" },
            { CountryCode.GH, "Ghana" },
            { CountryCode.GI, "Gibraltar" },
            { CountryCode.GL, "Greenland" },
            { CountryCode.GM, "Gambia" },
            { CountryCode.GN, "Guinea" },
            { CountryCode.GP, "Guadeloupe" },
            { CountryCode.GQ, "Equatorial Guinea" },
            { CountryCode.GR, "Greece" },
            { CountryCode.GS, "South GeorgiaΑndthe South Sandwich Islands" },
            { CountryCode.GT, "Guatemala" },
            { CountryCode.GU, "Guam" },
            { CountryCode.GW, "Guinea Bissau" },
            { CountryCode.GY, "Guyana" },
            { CountryCode.HK, "Hong Kong" },
            { CountryCode.HM, "Heard IslandΑnd Mc Donald Islands" },
            { CountryCode.HN, "Honduras" },
            { CountryCode.HR, "Croatia" },
            { CountryCode.HT, "Haiti" },
            { CountryCode.HU, "Hungary" },
            { CountryCode.ID, "Indonesia" },
            { CountryCode.IE, "Ireland" },
            { CountryCode.IL, "Israel" },
            { CountryCode.IM, "Isleof Man" },
            { CountryCode.IN, "India" },
            { CountryCode.IO, "British Indian Ocean Territory" },
            { CountryCode.IQ, "Iraq" },
            { CountryCode.IR, "Iran" },
            { CountryCode.IS, "Iceland" },
            { CountryCode.IT, "Italy" },
            { CountryCode.JE, "Jersey" },
            { CountryCode.JM, "Jamaica" },
            { CountryCode.JO, "Jordan" },
            { CountryCode.JP, "Japan" },
            { CountryCode.KE, "Kenya" },
            { CountryCode.KG, "Kyrgyzstan" },
            { CountryCode.KH, "Cambodia" },
            { CountryCode.KI, "Kiribati" },
            { CountryCode.KM, "Comoros" },
            { CountryCode.KN, "Saint KittsΑnd Nevis" },
            { CountryCode.KP, "North Korea" },
            { CountryCode.KR, "South Korea" },
            { CountryCode.KW, "Kuwait" },
            { CountryCode.KY, "Cayman Islands" },
            { CountryCode.KZ, "Kazakhstan" },
            { CountryCode.LA, "Laos" },
            { CountryCode.LB, "Lebanon" },
            { CountryCode.LC, "Saint Lucia" },
            { CountryCode.LI, "Liechtenstein" },
            { CountryCode.LK, "Sri Lanka" },
            { CountryCode.LR, "Liberia" },
            { CountryCode.LS, "Lesotho" },
            { CountryCode.LT, "Lithuania" },
            { CountryCode.LU, "Luxembourg" },
            { CountryCode.LV, "Latvia" },
            { CountryCode.LY, "Libya" },
            { CountryCode.MA, "Morocco" },
            { CountryCode.MC, "Monaco" },
            { CountryCode.MD, "Moldova" },
            { CountryCode.ME, "Montenegro" },
            { CountryCode.MF, "Saint Martin" },
            { CountryCode.MG, "Madagascar" },
            { CountryCode.MH, "Marshall Islands" },
            { CountryCode.MK, "Macedonia" },
            { CountryCode.ML, "Mali" },
            { CountryCode.MM, "Myanmar" },
            { CountryCode.MN, "Mongolia" },
            { CountryCode.MO, "Macau" },
            { CountryCode.MP, "Northern Mariana Islands" },
            { CountryCode.MQ, "Martinique" },
            { CountryCode.MR, "Mauritania" },
            { CountryCode.MS, "Montserrat" },
            { CountryCode.MT, "Malta" },
            { CountryCode.MU, "Mauritius" },
            { CountryCode.MV, "Maldives" },
            { CountryCode.MW, "Malawi" },
            { CountryCode.MX, "Mexico" },
            { CountryCode.MY, "Malaysia" },
            { CountryCode.MZ, "Mozambique" },
            { CountryCode.NA, "Namibia" },
            { CountryCode.NC, "New Caledonia" },
            { CountryCode.NE, "Niger" },
            { CountryCode.NF, "Norfolk Island" },
            { CountryCode.NG, "Nigeria" },
            { CountryCode.NI, "Nicaragua" },
            { CountryCode.NL, "Netherlands" },
            { CountryCode.NO, "Norway" },
            { CountryCode.NP, "Nepal" },
            { CountryCode.NR, "Nauru" },
            { CountryCode.NU, "Niue" },
            { CountryCode.NZ, "New Zealand" },
            { CountryCode.OM, "Oman" },
            { CountryCode.PA, "Panama" },
            { CountryCode.PE, "Peru" },
            { CountryCode.PF, "French Polynesia" },
            { CountryCode.PG, "Papua New Guinea" },
            { CountryCode.PH, "Philippines" },
            { CountryCode.PK, "Pakistan" },
            { CountryCode.PL, "Poland" },
            { CountryCode.PM, "Saint Pierre And Miquelon" },
            { CountryCode.PN, "Pitcairn" },
            { CountryCode.PR, "Puerto Rico" },
            { CountryCode.PS, "Palestine" },
            { CountryCode.PT, "Portugal" },
            { CountryCode.PW, "Palau" },
            { CountryCode.PY, "Paraguay" },
            { CountryCode.QA, "Qatar" },
            { CountryCode.RE, "Reunion" },
            { CountryCode.RO, "Romania" },
            { CountryCode.RS, "Serbia" },
            { CountryCode.RU, "Russia" },
            { CountryCode.RW, "Rwanda" },
            { CountryCode.SA, "Saudi Arabia" },
            { CountryCode.SB, "Solomon Islands" },
            { CountryCode.SC, "Seychelles" },
            { CountryCode.SD, "Sudan" },
            { CountryCode.SE, "Sweden" },
            { CountryCode.SG, "Singapore" },
            { CountryCode.SH, "Saint Helena" },
            { CountryCode.SI, "Slovenia" },
            { CountryCode.SJ, "Svalbard And Jan Mayen" },
            { CountryCode.SK, "Slovakia" },
            { CountryCode.SL, "Sierra Leone" },
            { CountryCode.SM, "San Marino" },
            { CountryCode.SN, "Senegal" },
            { CountryCode.SO, "Somalia" },
            { CountryCode.SR, "Suriname" },
            { CountryCode.ST, "Sao Tome And Principe" },
            { CountryCode.SV, "El Salvador" },
            { CountryCode.SY, "Syria" },
            { CountryCode.SZ, "Swaziland" },
            { CountryCode.TC, "Turks And Caicos Islands" },
            { CountryCode.TD, "Chad" },
            { CountryCode.TF, "French Southern Territories" },
            { CountryCode.TG, "Togo" },
            { CountryCode.TH, "Thailand" },
            { CountryCode.TJ, "Tajikistan" },
            { CountryCode.TK, "Tokelau" },
            { CountryCode.TL, "East Timor" },
            { CountryCode.TM, "Turkmenistan" },
            { CountryCode.TN, "Tunisia" },
            { CountryCode.TO, "Tonga" },
            { CountryCode.TR, "Turkey" },
            { CountryCode.TT, "Trinidad And Tobago" },
            { CountryCode.TV, "Tuvalu" },
            { CountryCode.TW, "Taiwan" },
            { CountryCode.TZ, "Tanzania" },
            { CountryCode.UA, "Ukraine" },
            { CountryCode.UG, "Uganda" },
            { CountryCode.UM, "United States Minor Outlying Islands" },
            { CountryCode.US, "United States" },
            { CountryCode.UY, "Uruguay" },
            { CountryCode.UZ, "Uzbekistan" },
            { CountryCode.VA, "Vatican" },
            { CountryCode.VC, "Saint Vincent Andthe Grenadines" },
            { CountryCode.VE, "Venezuela" },
            { CountryCode.VG, "British Virgin Islands" },
            { CountryCode.VI, "U S Virgin Islands" },
            { CountryCode.VN, "Vietnam" },
            { CountryCode.VU, "Vanuatu" },
            { CountryCode.WF, "WallisΑnd Futuna" },
            { CountryCode.WS, "Samoa" },
            { CountryCode.YE, "Yemen" },
            { CountryCode.YT, "Mayotte" },
            { CountryCode.ZA, "South Africa" },
            { CountryCode.ZM, "Zambia" },
            { CountryCode.ZW, "Zimbabwe" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Returns the localized representation of the specified <paramref name="value"/>
        /// </summary>
        /// <param name="value">The value</param>
        /// <returns></returns>
        public static string ToLocalizedString(this CountryCode value) => CountryCodeToCountryNameMapper[value];
    }
}