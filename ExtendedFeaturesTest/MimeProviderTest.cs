using System.Net.Mime;

using Xunit;

namespace Test
{
	public class MimeProviderTest
	{
		[Fact]
		public void GetMIMETest()
		{
			using var s = System.IO.File.Create("./test.md");
			s.Close();
			Assert.Equal("text/markdown", MimeProvider.GetMIME("./test.md"));
			System.IO.File.Delete("./test.md");
			Assert.Equal("application/octet-stream", MimeProvider.GetMIME("aaa"));
			Assert.Equal("application/postscript", MimeProvider.GetMIME("ai"));
		}
	}
}