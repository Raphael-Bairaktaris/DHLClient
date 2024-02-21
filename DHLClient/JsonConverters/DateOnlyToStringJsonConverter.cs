using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// The <see cref="DateOnlyToStringJsonConverter"/> that converts a <see cref="DateOnly"/> to <see cref="string"/>
    /// </summary>
    public class DateOnlyToStringJsonConverter : JsonConverter<DateOnly>
    {
        #region Constants

        /// <summary>
        /// The format that is used for serializing and deserializing dates
        /// </summary>
        public const string DateFormat = "yyyy-MM-dd";

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DateOnlyToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override DateOnly ReadJson(JsonReader reader, Type objectType, DateOnly existingValue, bool hasExistingValue, JsonSerializer serializer)
            => DateOnly.ParseExact(serializer.Deserialize<string>(reader)!, DateFormat);

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, DateOnly value, JsonSerializer serializer)
            => writer.WriteValue(value.ToString(DateFormat));

        #endregion
    }
}
