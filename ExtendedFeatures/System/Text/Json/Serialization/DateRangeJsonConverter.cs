namespace System.Text.Json.Serialization
{
#if NET6_0_OR_GREATER
	/// <summary>
	/// DateRange的json解析
	/// </summary>
	public class DateRangeJsonConverter : JsonConverter<DateRange>
	{
		/// <inheritdoc/>
		public override DateRange Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return ReadCore(ref reader, typeToConvert, options);
		}

		/// <inheritdoc/>
		public override void Write(Utf8JsonWriter writer, DateRange value, JsonSerializerOptions options) => WriteCore(writer, value, options);

		internal static DateRange ReadCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartArray) throw new JsonException();
			reader.Read();
			var startTime = DateOnly.Parse(reader.GetString() ?? throw new JsonException());
			reader.Read();
			var endTime = DateOnly.Parse(reader.GetString() ?? throw new JsonException());

			if (!reader.Read() || reader.TokenType != JsonTokenType.EndArray)
			{
				throw new JsonException();
			}

			return new DateRange { StartDate = startTime, EndDate = endTime };
		}
		internal static void WriteCore(Utf8JsonWriter writer, DateRange value, JsonSerializerOptions options)
		{
			writer.WriteStartArray();
			writer.WriteStringValue(value.StartDate.ToString("o"));
			writer.WriteStringValue(value.EndDate.ToString("o"));
			writer.WriteEndArray();
		}
	}
#endif
}
