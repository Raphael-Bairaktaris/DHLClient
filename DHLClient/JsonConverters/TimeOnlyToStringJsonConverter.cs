using Newtonsoft.Json;
using System.Globalization;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="JsonCoverter"/> that is used to convert a <see cref="TimeOnly"/> to <see cref="string"/>
    /// </summary>
    public class TimeOnlyToStringJsonConverter : JsonConverter<TimeOnly>
    {
        #region Constants

        /// <summary>
        /// The format that is used for serializing and deserializing <see cref="TimeOnly"/>
        /// </summary>
        public static readonly string[] TimeFormats = new[] { "HH:mm", "HH:mm:ss" };

        #endregion

        #region Public Properties

        /// <summary>
        /// A flag indicating whether the time should be fully displayed
        /// </summary>
        public bool ShouldDisplayFullTime { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TimeOnlyToStringJsonConverter(bool shouldDisplayFullTime) : base()
        {
            ShouldDisplayFullTime = shouldDisplayFullTime;
        }

        public TimeOnlyToStringJsonConverter() : this(shouldDisplayFullTime: false)
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override TimeOnly ReadJson(JsonReader reader, Type objectType, TimeOnly existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<string>(reader)!;

            if (readerValue.IsNullOrEmpty())
                return default;

            return TimeOnly.ParseExact(readerValue, TimeFormats, CultureInfo.InvariantCulture);
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, TimeOnly value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString(ShouldDisplayFullTime ? TimeFormats[0] : TimeFormats[1], CultureInfo.InvariantCulture));
        }

        #endregion
    }
}
