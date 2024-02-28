namespace System.Text.Json.Serialization
{
#if NET6_0_OR_GREATER
	/// <summary>
	/// 可为空的DateRange的json解析
	/// </summary>
	public class NullableDateRangeJsonConverter : JsonConverter<DateRange?>
	{
		/// <inheritdoc/>
		public override DateRange? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.Null) return null;
			else
				return DateRangeJsonConverter.ReadCore(ref reader, typeToConvert, options);
		}

		/// <inheritdoc/>
		public override void Write(Utf8JsonWriter writer, DateRange? value, JsonSerializerOptions options)
		{
			if (value is null) writer.WriteNullValue();
			else DateRangeJsonConverter.WriteCore(writer, value.Value, options);
		}
	}
#endif
}
