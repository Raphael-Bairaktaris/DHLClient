using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="DateTimeOffset"/> to an <see cref="int"/> that represents the unix timestamp
    /// </summary>
    public class DateTimeOffsetToUnixTimestampJsonConverter : JsonConverter<DateTimeOffset>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DateTimeOffsetToUnixTimestampJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override DateTimeOffset ReadJson(JsonReader reader, Type objectType, DateTimeOffset existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<int>(reader);

            return DateTimeOffset.FromUnixTimeSeconds(readerValue);
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, DateTimeOffset value, JsonSerializer serializer) => writer.WriteValue(value.ToUnixTimeSeconds());

        #endregion
    }
}
