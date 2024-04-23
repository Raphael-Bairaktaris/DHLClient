using Newtonsoft.Json;
using System.Xml;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used to convert a <see cref="TimeSpan"/> to <see cref="string"/>
    /// </summary>
    public class TimespanDurationToStringJsonConverter : JsonConverter<TimeSpan>
    {
        #region Constants

        /// <summary>
        /// ISO 8601 Durations are expressed using the following format, where (n) is replaced by the value for each of the date and time elements that follow the (n)
        /// </summary>
        public const string TimespanDurationFormat = "P(n)Y(n)M(n)DT(n)H(n)M(n)S";

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TimespanDurationToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override TimeSpan ReadJson(JsonReader reader, Type objectType, TimeSpan existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<string>(reader)!;

            return XmlConvert.ToTimeSpan(readerValue);
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, TimeSpan value, JsonSerializer serializer) 
            => writer.WriteValue(value.ToString(TimespanDurationFormat));

        #endregion
    }
}
