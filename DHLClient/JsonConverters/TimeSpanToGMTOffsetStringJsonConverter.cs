using Newtonsoft.Json;

namespace DHLClient.JsonConverters
{
    internal class TimeSpanToGMTOffsetStringJsonConverter : JsonConverter<TimeSpan?>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TimeSpanToGMTOffsetStringJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override TimeSpan? ReadJson(JsonReader reader, Type objectType, TimeSpan? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string?>(reader);

            if (value is null)
                return null;

            var parts = value.Substring(1).Split(":");

            var hours = int.Parse(parts[0]);
            var minutes = int.Parse(parts[1]);

            return new TimeSpan(hours, minutes, 0);
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, TimeSpan? value, JsonSerializer serializer)
        {
            if (value is null)
                return;

            var hours = value.Value.Hours.ToString();
            if (hours.Length == 1)
                hours = "0" + hours;

            var minutes = value.Value.Minutes.ToString();
            if (minutes.Length == 1)
                minutes = "0" + minutes;
            writer.WriteValue($"+{hours}:{minutes}");
        }

        #endregion
    }
}
