using Newtonsoft.Json;
using System.Globalization;

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="DateOnly"/> to <see cref="string"/>
    /// </summary>
    public class DateOnlyToStringJsonConverter : JsonConverter<DateOnly?>
    {
        #region Constants

        /// <summary>
        /// The format that is used for serializing and deserializing dates
        /// </summary>
        public static readonly string[] DateFormats = new[] { "d-M-yyyy", "yyyy-MM-dd" };

        #endregion

        #region Public Properties

        /// <summary>
        /// A flag indicating whether the format in use is "d-M-yyyy" or "yyyy-MM-dd"
        /// </summary>
        public bool ShouldUseDMYFormat { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DateOnlyToStringJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override DateOnly? ReadJson(JsonReader reader, Type objectType, DateOnly? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<string?>(reader);

            if (readerValue.IsNullOrEmpty())
                return null;

            return DateOnly.ParseExact(readerValue, DateFormats, CultureInfo.InvariantCulture);
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, DateOnly? value, JsonSerializer serializer)
        {
            if (value is null)
                return;

            writer.WriteValue(value.Value.ToString(ShouldUseDMYFormat ? DateFormats[0] : DateFormats[1], CultureInfo.InvariantCulture));
        }

        #endregion
    }
}
