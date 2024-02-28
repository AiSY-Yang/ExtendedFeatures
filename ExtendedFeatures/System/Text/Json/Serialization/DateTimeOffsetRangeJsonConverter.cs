namespace System.Text.Json.Serialization
{
	/// <summary>
	/// DateTimeOffsetRange的json解析
	/// </summary>
	public class DateTimeOffsetRangeJsonConverter : JsonConverter<DateTimeOffsetRange>
	{
		/// <inheritdoc/>
		public override DateTimeOffsetRange Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return ReadCore(ref reader, typeToConvert, options);
		}

		/// <inheritdoc/>
		public override void Write(Utf8JsonWriter writer, DateTimeOffsetRange value, JsonSerializerOptions options) => WriteCore(writer, value, options);

		internal static DateTimeOffsetRange ReadCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartArray) throw new JsonException();
			reader.Read();
			var startTime = DateTimeOffset.Parse(reader.GetString() ?? throw new JsonException());
			reader.Read();
			var endTime = DateTimeOffset.Parse(reader.GetString() ?? throw new JsonException());

			if (!reader.Read() || reader.TokenType != JsonTokenType.EndArray)
			{
				throw new JsonException();
			}

			return new DateTimeOffsetRange { StartDateTimeOffset = startTime, EndDateTimeOffset = endTime };
		}
		internal static void WriteCore(Utf8JsonWriter writer, DateTimeOffsetRange value, JsonSerializerOptions options)
		{
			writer.WriteStartArray();
			writer.WriteStringValue(value.StartDateTimeOffset);
			writer.WriteStringValue(value.EndDateTimeOffset);
			writer.WriteEndArray();
		}
	}
}
