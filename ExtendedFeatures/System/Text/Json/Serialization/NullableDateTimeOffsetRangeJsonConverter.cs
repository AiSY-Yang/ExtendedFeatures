namespace System.Text.Json.Serialization
{
	/// <summary>
	/// 可为空的DateTimeOffsetRange解析
	/// </summary>
	public class NullableDateTimeOffsetRangeJsonConverter : JsonConverter<DateTimeOffsetRange?>
	{
		/// <inheritdoc/>
		public override DateTimeOffsetRange? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.Null) return null;
			else
				return DateTimeOffsetRangeJsonConverter.ReadCore(ref reader, typeToConvert, options);
		}

		/// <inheritdoc/>
		public override void Write(Utf8JsonWriter writer, DateTimeOffsetRange? value, JsonSerializerOptions options)
		{
			if (value is null) writer.WriteNullValue();
			else DateTimeOffsetRangeJsonConverter.WriteCore(writer, value.Value, options);
		}
	}
}
