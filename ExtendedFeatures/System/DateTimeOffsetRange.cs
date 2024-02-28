using System.Text.Json.Serialization;

namespace System
{
	/// <summary>
	/// 时间范围
	/// </summary>
	[JsonConverter(typeof(DateTimeOffsetRangeJsonConverter))]
	public struct DateTimeOffsetRange
	{
		/// <summary>
		/// 开始时间
		/// </summary>
		public DateTimeOffset StartDateTimeOffset { get; set; }
		/// <summary>
		/// 结束时间
		/// </summary>
		public DateTimeOffset EndDateTimeOffset { get; set; }
	}
}
