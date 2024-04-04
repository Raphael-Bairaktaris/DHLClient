using Newtonsoft.Json;
using System.Globalization;

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="DateTimeOffset"/> to a <see cref="string"/> and can be used when for date and times using the
    /// following format: 2006-06-26T17:00:00 GMT+01:00
    /// </summary>
    public class DateTimeOffsetWithGMTPrefixToStringJsonConverter : JsonConverter<DateTimeOffset?>
    {
        #region Constants

        public const string Format = "yyyy-MM-ddTHH:mm:ss \'GMT\'zzz";

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DateTimeOffsetWithGMTPrefixToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override DateTimeOffset? ReadJson(JsonReader reader, Type objectType, DateTimeOffset? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<string?>(reader);

            if (readerValue.IsNullOrEmpty())
                return null;

            return DateTimeOffset.ParseExact(readerValue, Format, CultureInfo.InvariantCulture);
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, DateTimeOffset? value, JsonSerializer serializer)
        {
            if (value is null)
                return;

            writer.WriteValue(value.Value.ToString(Format, CultureInfo.InvariantCulture));
        }

        #endregion
    }
}
