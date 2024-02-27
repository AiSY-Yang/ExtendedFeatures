using System.Text.Json.Serialization;

namespace System
{
#if NET6_0_OR_GREATER
	/// <summary>
	/// 日期范围
	/// </summary>
	[JsonConverter(typeof(DateRangeJsonConverter))]
	public struct DateRange
	{
		public DateOnly StartTime { get; set; }
		public DateOnly EndTime { get; set; }
	}
#endif
}
