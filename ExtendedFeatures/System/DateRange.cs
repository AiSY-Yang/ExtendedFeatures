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
		/// <summary>
		/// 开始日期
		/// </summary>
		public DateOnly StartDate { get; set; }
		/// <summary>
		/// 结束日期
		/// </summary>
		public DateOnly EndDate { get; set; }
	}
#endif
}
