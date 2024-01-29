using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point detail opening hour response
    /// </summary>
    public class ServicePointDetailOpeningHoursResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="OpeningHours"/> property
        /// </summary>
        private IEnumerable<ServicePointDetailOpeningHourResponseModel>? mOpeningHours;

        /// <summary>
        /// The member of the <see cref="HolidayDates"/> property
        /// </summary>
        private IEnumerable<string>? mHolidayDates;

        /// <summary>
        /// The member of the <see cref="HolidaysDates"/> property
        /// </summary>
        private IEnumerable<string>? mHolidaysDates;

        /// <summary>
        /// The member of the <see cref="PPCList"/> property
        /// </summary>
        private IEnumerable<string>? mPPCList;

        /// <summary>
        /// The member of the <see cref="CapabilityCodes"/> property
        /// </summary>
        private string? mCapabilityCodes;

        #endregion

        #region Public Properties

        /// <summary>
        /// Multiple opening hours entities can exist for the same week day.
        /// </summary>
        public IEnumerable<ServicePointDetailOpeningHourResponseModel> OpeningHours 
        { 
            get => mOpeningHours ?? Enumerable.Empty<ServicePointDetailOpeningHourResponseModel>();
            set => mOpeningHours = value;
        }

        /// <summary>
        /// Holiday details with date
        /// </summary>
        [JsonProperty("holidayDates")]
        public IEnumerable<string> HolidayDates 
        { 
            get => mHolidayDates ?? Enumerable.Empty<string>();
            set => mHolidayDates = value;
        }

        /// <summary>
        /// Holiday details with date
        /// </summary>
        [JsonProperty("holidaysDates")]
        public IEnumerable<string> HolidaysDates 
        { 
            get => mHolidaysDates ?? Enumerable.Empty<string>();
            set => mHolidaysDates = value;
        }

        /// <summary>
        /// Holiday details
        /// </summary>
        [JsonProperty("holidays")]
        public ServicePointDetailHolidayResponseModel Holidays { get; set; }

        /// <summary>
        /// An entity that lists all capabilities of a Service Point.
        /// </summary>
        [JsonProperty("servicePointCapabilities")]
        public ServicePointDetailCapabilitiesResponseModel ServicePointCapabilities { get; set; }

        /// <summary>
        /// Array of numbers L W H
        /// </summary>
        public PieceDimensionLimitResponseModel PieceDimensionsLimit { get; set; }

        /// <summary>
        /// Enumeration (CM or IN)
        /// </summary>
        [JsonProperty("pieceDimensionsLimitUnit")]
        public DimensionUnit PieceDimensionsLimitUnit { get; set; }

        /// <summary>
        /// The piece count limit
        /// </summary>
        [JsonProperty("pieceCountLimit")]
        public double PieceCountLimit { get; set; }

        /// <summary>
        /// Account prepaid shippers
        /// </summary>
        [JsonProperty("accountPrepaidShippers")]
        public bool HasAccountPrepaidShippers { get; set; }

        /// <summary>
        /// Prepaid shippers
        /// </summary>
        [JsonProperty("prepaidShippers")]
        public bool HasPrepaidShippers { get; set; }

        /// <summary>
        /// Pre-printed return label
        /// </summary>
        [JsonProperty("prePrintReturnLabel")]
        public bool HasPrePrinReturnLabel { get; set; }

        /// <summary>
        /// Indicates whether this particular service point can handle label free shipments or not
        /// </summary>
        [JsonProperty("labelFree")]
        public bool IsLabelFree { get; set; }

        /// <summary>
        /// The PPC list.
        /// </summary>
        [JsonProperty("ppcList")]
        public IEnumerable<string> PPCList
        {
            get => mPPCList ?? Enumerable.Empty<string>();
            set => mPPCList = value;
        }

        /// <summary>
        /// PPC codes available for this service point
        /// </summary>
        [JsonProperty("capabilityCodes")]
        public string CapabilityCodes
        {
            get => mCapabilityCodes ?? string.Empty;
            set => mCapabilityCodes = value;
        }

        /// <summary>
        /// Information about how the Service Point can be contacted
        /// </summary>
        [JsonProperty("contactDetails")]
        public ServicePointContactDetailResponseModel ContactDetails { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointDetailOpeningHoursResponseModel() : base()
        {

        }

        #endregion
    }
}