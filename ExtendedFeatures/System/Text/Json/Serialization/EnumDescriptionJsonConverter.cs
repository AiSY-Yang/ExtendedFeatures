namespace System.Text.Json.Serialization
{
#if NET5_0_OR_GREATER
	/// <summary>
	/// 枚举转换器 将枚举转换为Description所定义的内容
	/// </summary>
	public class EnumDescriptionJsonConverter : JsonConverter<ValueType>
	{
		/// <inheritdoc/>
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert.IsEnum || typeToConvert.IsGenericType && typeToConvert.GenericTypeArguments.Length == 1 && typeToConvert.GenericTypeArguments[0].IsEnum;
		}
		/// <inheritdoc/>
		public override ValueType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			throw new NotImplementedException();
		}
		/// <inheritdoc/>
		public override void Write(Utf8JsonWriter writer, ValueType value, JsonSerializerOptions options)
		{
			if (value == null)
				writer.WriteNullValue();
			else
				writer.WriteStringValue(GetDescription((value as Enum)!));
		}
		/// <summary>
		/// 通过反射获取枚举的描述 如果不存在描述则返回字符串
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		static string GetDescription(Enum source)
		{
			Reflection.FieldInfo? fi = source.GetType().GetField(source.ToString());
			if (fi == null) return source.ToString();
			ComponentModel.DescriptionAttribute[] attributes = (ComponentModel.DescriptionAttribute[])fi.GetCustomAttributes(typeof(ComponentModel.DescriptionAttribute), false);

			if (attributes != null && attributes.Length > 0) return attributes[0].Description;
			else return source.ToString();
		}
	}
#endif
}
