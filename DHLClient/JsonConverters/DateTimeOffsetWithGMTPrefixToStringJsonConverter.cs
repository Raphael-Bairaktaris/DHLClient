using Newtonsoft.Json;
using System.Globalization;

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="DateTimeOffset"/> to a <see cref="string"/> and can be used for date and times using the
    /// following format: 2006-06-26T17:00:00 GMT+01:00
    /// </summary>
    public class DateTimeOffsetWithGMTPrefixToStringJsonConverter : JsonConverter<DateTimeOffset?>
    {
        #region Constants

        /// <summary>
        /// The date time offset format
        /// </summary>
        public static readonly string[] Formats = new[] { "yyyy-MM-ddTHH:mm:ss \'GMT\'zzz", "yyyy-MM-ddTHH:mm:ss\'GMT\'zzz" };

        #endregion

        #region Public Properties

        /// <summary>
        /// A flag indicating whether the time and GMT prefix should get separated by space
        /// </summary>
        public bool ShouldSeparateTimeAndGMTWithSpace { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DateTimeOffsetWithGMTPrefixToStringJsonConverter(bool shouldSeparateTimeAndGMTWithSpace) : base()
        {
            ShouldSeparateTimeAndGMTWithSpace = shouldSeparateTimeAndGMTWithSpace;
        }

        /// <summary>
        /// Parameterless constructor
        /// </summary>
        public DateTimeOffsetWithGMTPrefixToStringJsonConverter() : this(shouldSeparateTimeAndGMTWithSpace: false)
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

            return DateTimeOffset.ParseExact(readerValue, Formats, CultureInfo.InvariantCulture);
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, DateTimeOffset? value, JsonSerializer serializer)
        {
            if (value is null)
                return;

            writer.WriteValue(value.Value.ToString(ShouldSeparateTimeAndGMTWithSpace ? Formats[0] : Formats[1], CultureInfo.InvariantCulture));
        }

        #endregion
    }
}