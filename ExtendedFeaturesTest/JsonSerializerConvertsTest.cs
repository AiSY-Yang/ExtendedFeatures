
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

using Xunit;

namespace ExtensionMethodsTests
{
	public class JsonSerializerConvertsTest
	{
		public JsonSerializerConvertsTest()
		{
		}
#if NET5_0_OR_GREATER
		public enum MyEnum
		{
			[Description("Description")]
			Key = 1,
			NoDescriptionKey = 2,
		}
		public class MyClass
		{
			public MyEnum MyEnumWith0 { get; set; }
			public MyEnum MyEnumWith1 { get; set; }
			public MyEnum? NullableMyEnumWith0 { get; set; }
			public MyEnum? NullableMyEnumWith1 { get; set; }
			public MyEnum? NullableMyEnumWithNull { get; set; }
			public MyEnum? NullableMyEnumWith2 { get; set; }
		}
		MyClass value = new MyClass()
		{
			MyEnumWith1 = MyEnum.Key,
			MyEnumWith0 = 0,
			NullableMyEnumWith0 = 0,
			NullableMyEnumWith1 = MyEnum.Key,
			NullableMyEnumWithNull = null,
			NullableMyEnumWith2 = MyEnum.NoDescriptionKey,
		};
		[Fact]
		public void EnumDescriptionJsonConverter()
		{
			JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions() { WriteIndented = true };
			Assert.Equal(@"{
  ""MyEnumWith0"": 0,
  ""MyEnumWith1"": 1,
  ""NullableMyEnumWith0"": 0,
  ""NullableMyEnumWith1"": 1,
  ""NullableMyEnumWithNull"": null,
  ""NullableMyEnumWith2"": 2
}", JsonSerializer.Serialize(value, jsonSerializerOptions));
			jsonSerializerOptions = new JsonSerializerOptions() { WriteIndented = true };
			jsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
			Assert.Equal(@"{
  ""MyEnumWith0"": 0,
  ""MyEnumWith1"": ""Key"",
  ""NullableMyEnumWith0"": 0,
  ""NullableMyEnumWith1"": ""Key"",
  ""NullableMyEnumWithNull"": null,
  ""NullableMyEnumWith2"": ""NoDescriptionKey""
}", JsonSerializer.Serialize(value, jsonSerializerOptions));
			jsonSerializerOptions = new JsonSerializerOptions() { WriteIndented = true };
			jsonSerializerOptions.Converters.Add(new EnumDescriptionJsonConverter());
			Assert.Equal(@"{
  ""MyEnumWith0"": ""0"",
  ""MyEnumWith1"": ""Description"",
  ""NullableMyEnumWith0"": ""0"",
  ""NullableMyEnumWith1"": ""Description"",
  ""NullableMyEnumWithNull"": null,
  ""NullableMyEnumWith2"": ""NoDescriptionKey""
}", JsonSerializer.Serialize(value, jsonSerializerOptions));

		}

#endif
#if NET6_0_OR_GREATER
		[Fact]
		public void DateOnlyJsonConverter()
		{
			JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
			jsonSerializerOptions.Converters.Add(new DateRangeJsonConverter());
			var str = "[\"2022-12-01\",\"2023-10-01\"]";

			var dateRange = JsonSerializer.Deserialize<DateRange>(str, jsonSerializerOptions);
			Assert.Equal(DateOnly.Parse("2022-12-01"), dateRange.StartDate);
			Assert.Equal(DateOnly.Parse("2023-10-01"), dateRange.EndDate);
			Assert.Equal(str, JsonSerializer.Serialize(dateRange, jsonSerializerOptions));
			var dateRange2 = JsonSerializer.Deserialize<DateRange>("[\"2022-12-01\",\n\"2023-10-01\"]", jsonSerializerOptions);
			Assert.Equal(dateRange, dateRange2);
		}
		[Fact]
		public void NUllableDateOnlyJsonConverter()
		{
			JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
			jsonSerializerOptions.Converters.Add(new DateRangeJsonConverter());
			var str = "null";

			var dateRange = JsonSerializer.Deserialize<DateRange?>(str, jsonSerializerOptions);
			Assert.Null(dateRange);
			Assert.Equal(str, JsonSerializer.Serialize(dateRange, jsonSerializerOptions));
			var dateRange2 = JsonSerializer.Deserialize<DateRange>("[\"2022-12-01\",\n\"2023-10-01\"]", jsonSerializerOptions);
			Assert.Equal(DateOnly.Parse("2022-12-01"), dateRange2.StartDate);
		}
		[Fact]
		public void DateTimeOffsetRangeJsonConverter()
		{
			JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
			jsonSerializerOptions.Converters.Add(new DateRangeJsonConverter());
			jsonSerializerOptions.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
			var str = "[\"2022-12-01T12:23:34.1234567+01:00\",\"2023-10-01T00:00:00+00:00\"]";

			var dateRange = JsonSerializer.Deserialize<DateTimeOffsetRange>(str, jsonSerializerOptions);
			Assert.Equal(DateTimeOffset.Parse("2022-12-01T12:23:34.1234567+01:00"), dateRange.StartDateTimeOffset);
			Assert.Equal(DateTimeOffset.Parse("2023-10-01Z"), dateRange.EndDateTimeOffset);
			Assert.Equal(str, JsonSerializer.Serialize(dateRange, jsonSerializerOptions));
			var dateRange2 = JsonSerializer.Deserialize<DateTimeOffsetRange>("[\"2022-12-01T12:23:34.1234567+01:00\",\n \"2023-10-01Z\"]", jsonSerializerOptions);
			Assert.Equal(dateRange, dateRange2);
		}
		[Fact]
		public void NUllableDateTimeOffsetRangeJsonConverter()
		{
			JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
			jsonSerializerOptions.Converters.Add(new DateRangeJsonConverter());
			var str = "null";

			var dateRange = JsonSerializer.Deserialize<DateTimeOffsetRange?>(str, jsonSerializerOptions);
			Assert.Null(dateRange);
			Assert.Equal(str, JsonSerializer.Serialize(dateRange, jsonSerializerOptions));
			var dateRange2 = JsonSerializer.Deserialize<DateTimeOffsetRange>("[\"2022-12-01T12:23:34+01:00\",\n \"2023-10-01Z\"]", jsonSerializerOptions);
			Assert.Equal(DateTimeOffset.Parse("2022-12-01T12:23:34+01:00"), dateRange2.StartDateTimeOffset);
		}
#endif
	}
}
