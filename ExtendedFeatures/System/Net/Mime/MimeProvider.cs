using System.Collections.Generic;
using System.IO;

namespace System.Net.Mime
{
	/// <summary>
	/// 日期范围
	/// </summary>
	public static class MimeProvider
	{
		/// <summary>
		/// 获取MIME类型,可以传入文件名或者文件扩展名
		/// </summary>
		/// <param name="Name">文件名或者扩展名</param>
		/// <returns></returns>
		public static string GetMIME(string Name)
		{
			var extensionName = Path.GetExtension(Name)?.Trim();
			extensionName = string.IsNullOrWhiteSpace(extensionName)
				? Name.StartsWith('.') ? Name[1..] : Name
				: extensionName[1..];
			return MIME.TryGetValue(extensionName, out string? value) ? value : "application/octet-stream";
		}
		#region field

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
		public const string ai = "application/postscript";
		public const string aif = "audio/x-aiff";
		public const string aifc = "audio/x-aiff";
		public const string aiff = "audio/x-aiff";
		public const string asc = "text/plain";
		public const string atom = "application/atom+xml";
		public const string au = "audio/basic";
		public const string avi = "video/x-msvideo";
		public const string bcpio = "application/x-bcpio";
		public const string bin = "application/octet-stream";
		public const string bmp = "image/bmp";
		public const string cdf = "application/x-netcdf";
		public const string cgm = "image/cgm";
		public const string @class = "application/octet-stream";
		public const string cpio = "application/x-cpio";
		public const string cpt = "application/mac-compactpro";
		public const string csh = "application/x-csh";
		public const string css = "text/css";
		public const string dcr = "application/x-director";
		public const string dif = "video/x-dv";
		public const string dir = "application/x-director";
		public const string djv = "image/vnd.djvu";
		public const string djvu = "image/vnd.djvu";
		public const string dll = "application/octet-stream";
		public const string dmg = "application/octet-stream";
		public const string dms = "application/octet-stream";
		public const string doc = "application/msword";
		public const string docx = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
		public const string dotx = "application/vnd.openxmlformats-officedocument.wordprocessingml.template";
		public const string docm = "application/vnd.ms-word.document.macroEnabled.12";
		public const string dotm = "application/vnd.ms-word.template.macroEnabled.12";
		public const string dtd = "application/xml-dtd";
		public const string dv = "video/x-dv";
		public const string dvi = "application/x-dvi";
		public const string dxr = "application/x-director";
		public const string eps = "application/postscript";
		public const string etx = "text/x-setext";
		public const string exe = "application/octet-stream";
		public const string ez = "application/andrew-inset";
		public const string gif = "image/gif";
		public const string gram = "application/srgs";
		public const string grxml = "application/srgs+xml";
		public const string gtar = "application/x-gtar";
		public const string hdf = "application/x-hdf";
		public const string hqx = "application/mac-binhex40";
		public const string htm = "text/html";
		public const string html = "text/html";
		public const string ice = "x-conference/x-cooltalk";
		public const string ico = "image/x-icon";
		public const string ics = "text/calendar";
		public const string ief = "image/ief";
		public const string ifb = "text/calendar";
		public const string iges = "model/iges";
		public const string igs = "model/iges";
		public const string jnlp = "application/x-java-jnlp-file";
		public const string jp2 = "image/jp2";
		public const string jpe = "image/jpeg";
		public const string jpeg = "image/jpeg";
		public const string jpg = "image/jpeg";
		public const string js = "application/javascript";
		public const string kar = "audio/midi";
		public const string latex = "application/x-latex";
		public const string lha = "application/octet-stream";
		public const string lzh = "application/octet-stream";
		public const string m3u = "audio/x-mpegurl";
		public const string m4a = "audio/mp4a-latm";
		public const string m4b = "audio/mp4a-latm";
		public const string m4p = "audio/mp4a-latm";
		public const string m4u = "video/vnd.mpegurl";
		public const string m4v = "video/x-m4v";
		public const string mac = "image/x-macpaint";
		public const string md = "text/markdown";
		public const string man = "application/x-troff-man";
		public const string mathml = "application/mathml+xml";
		public const string me = "application/x-troff-me";
		public const string mesh = "model/mesh";
		public const string mid = "audio/midi";
		public const string midi = "audio/midi";
		public const string mif = "application/vnd.mif";
		public const string mov = "video/quicktime";
		public const string movie = "video/x-sgi-movie";
		public const string mp2 = "audio/mpeg";
		public const string mp3 = "audio/mpeg";
		public const string mp4 = "video/mp4";
		public const string mpe = "video/mpeg";
		public const string mpeg = "video/mpeg";
		public const string mpg = "video/mpeg";
		public const string mpga = "audio/mpeg";
		public const string ms = "application/x-troff-ms";
		public const string msh = "model/mesh";
		public const string mxu = "video/vnd.mpegurl";
		public const string nc = "application/x-netcdf";
		public const string oda = "application/oda";
		public const string ogg = "application/ogg";
		public const string pbm = "image/x-portable-bitmap";
		public const string pct = "image/pict";
		public const string pdb = "chemical/x-pdb";
		public const string pdf = "application/pdf";
		public const string pgm = "image/x-portable-graymap";
		public const string pgn = "application/x-chess-pgn";
		public const string pic = "image/pict";
		public const string pict = "image/pict";
		public const string png = "image/png";
		public const string pnm = "image/x-portable-anymap";
		public const string pnt = "image/x-macpaint";
		public const string pntg = "image/x-macpaint";
		public const string ppm = "image/x-portable-pixmap";
		public const string ppt = "application/vnd.ms-powerpoint";
		public const string pptx = "application/vnd.openxmlformats-officedocument.presentationml.presentation";
		public const string potx = "application/vnd.openxmlformats-officedocument.presentationml.template";
		public const string ppsx = "application/vnd.openxmlformats-officedocument.presentationml.slideshow";
		public const string ppam = "application/vnd.ms-powerpoint.addin.macroEnabled.12";
		public const string pptm = "application/vnd.ms-powerpoint.presentation.macroEnabled.12";
		public const string potm = "application/vnd.ms-powerpoint.template.macroEnabled.12";
		public const string ppsm = "application/vnd.ms-powerpoint.slideshow.macroEnabled.12";
		public const string ps = "application/postscript";
		public const string qt = "video/quicktime";
		public const string qti = "image/x-quicktime";
		public const string qtif = "image/x-quicktime";
		public const string ra = "audio/x-pn-realaudio";
		public const string ram = "audio/x-pn-realaudio";
		public const string ras = "image/x-cmu-raster";
		public const string rdf = "application/rdf+xml";
		public const string rgb = "image/x-rgb";
		public const string rm = "application/vnd.rn-realmedia";
		public const string roff = "application/x-troff";
		public const string rtf = "text/rtf";
		public const string rtx = "text/richtext";
		public const string sgm = "text/sgml";
		public const string sgml = "text/sgml";
		public const string sh = "application/x-sh";
		public const string shar = "application/x-shar";
		public const string silo = "model/mesh";
		public const string sit = "application/x-stuffit";
		public const string skd = "application/x-koan";
		public const string skm = "application/x-koan";
		public const string skp = "application/x-koan";
		public const string skt = "application/x-koan";
		public const string smi = "application/smil";
		public const string smil = "application/smil";
		public const string snd = "audio/basic";
		public const string so = "application/octet-stream";
		public const string spl = "application/x-futuresplash";
		public const string src = "application/x-wais-source";
		public const string sv4cpio = "application/x-sv4cpio";
		public const string sv4crc = "application/x-sv4crc";
		public const string svg = "image/svg+xml";
		public const string swf = "application/x-shockwave-flash";
		public const string t = "application/x-troff";
		public const string tar = "application/x-tar";
		public const string tcl = "application/x-tcl";
		public const string tex = "application/x-tex";
		public const string texi = "application/x-texinfo";
		public const string texinfo = "application/x-texinfo";
		public const string tif = "image/tiff";
		public const string tiff = "image/tiff";
		public const string tr = "application/x-troff";
		public const string tsv = "text/tab-separated-values";
		public const string txt = "text/plain";
		public const string ustar = "application/x-ustar";
		public const string vcd = "application/x-cdlink";
		public const string vrml = "model/vrml";
		public const string vxml = "application/voicexml+xml";
		public const string wav = "audio/x-wav";
		public const string wbmp = "image/vnd.wap.wbmp";
		public const string wbmxl = "application/vnd.wap.wbxml";
		public const string wml = "text/vnd.wap.wml";
		public const string wmlc = "application/vnd.wap.wmlc";
		public const string wmls = "text/vnd.wap.wmlscript";
		public const string wmlsc = "application/vnd.wap.wmlscriptc";
		public const string wrl = "model/vrml";
		public const string xbm = "image/x-xbitmap";
		public const string xht = "application/xhtml+xml";
		public const string xhtml = "application/xhtml+xml";
		public const string xls = "application/vnd.ms-excel";
		public const string xml = "application/xml";
		public const string xpm = "image/x-xpixmap";
		public const string xsl = "application/xml";
		public const string xlsx = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
		public const string xltx = "application/vnd.openxmlformats-officedocument.spreadsheetml.template";
		public const string xlsm = "application/vnd.ms-excel.sheet.macroEnabled.12";
		public const string xltm = "application/vnd.ms-excel.template.macroEnabled.12";
		public const string xlam = "application/vnd.ms-excel.addin.macroEnabled.12";
		public const string xlsb = "application/vnd.ms-excel.sheet.binary.macroEnabled.12";
		public const string xslt = "application/xslt+xml";
		public const string xul = "application/vnd.mozilla.xul+xml";
		public const string xwd = "image/x-xwindowdump";
		public const string xyz = "chemical/x-xyz";
		public const string zip = "application/zip";
		#endregion
		private static readonly Dictionary<string, string> MIME = new Dictionary<string, string>
  {
	{"ai", "application/postscript"},
	{"aif", "audio/x-aiff"},
	{"aifc", "audio/x-aiff"},
	{"aiff", "audio/x-aiff"},
	{"asc", "text/plain"},
	{"atom", "application/atom+xml"},
	{"au", "audio/basic"},
	{"avi", "video/x-msvideo"},
	{"bcpio", "application/x-bcpio"},
	{"bin", "application/octet-stream"},
	{"bmp", "image/bmp"},
	{"cdf", "application/x-netcdf"},
	{"cgm", "image/cgm"},
	{"class", "application/octet-stream"},
	{"cpio", "application/x-cpio"},
	{"cpt", "application/mac-compactpro"},
	{"csh", "application/x-csh"},
	{"css", "text/css"},
	{"dcr", "application/x-director"},
	{"dif", "video/x-dv"},
	{"dir", "application/x-director"},
	{"djv", "image/vnd.djvu"},
	{"djvu", "image/vnd.djvu"},
	{"dll", "application/octet-stream"},
	{"dmg", "application/octet-stream"},
	{"dms", "application/octet-stream"},
	{"doc", "application/msword"},
	{"docx","application/vnd.openxmlformats-officedocument.wordprocessingml.document"},
	{"dotx", "application/vnd.openxmlformats-officedocument.wordprocessingml.template"},
	{"docm","application/vnd.ms-word.document.macroEnabled.12"},
	{"dotm","application/vnd.ms-word.template.macroEnabled.12"},
	{"dtd", "application/xml-dtd"},
	{"dv", "video/x-dv"},
	{"dvi", "application/x-dvi"},
	{"dxr", "application/x-director"},
	{"eps", "application/postscript"},
	{"etx", "text/x-setext"},
	{"exe", "application/octet-stream"},
	{"ez", "application/andrew-inset"},
	{"gif", "image/gif"},
	{"gram", "application/srgs"},
	{"grxml", "application/srgs+xml"},
	{"gtar", "application/x-gtar"},
	{"hdf", "application/x-hdf"},
	{"hqx", "application/mac-binhex40"},
	{"htm", "text/html"},
	{"html", "text/html"},
	{"ice", "x-conference/x-cooltalk"},
	{"ico", "image/x-icon"},
	{"ics", "text/calendar"},
	{"ief", "image/ief"},
	{"ifb", "text/calendar"},
	{"iges", "model/iges"},
	{"igs", "model/iges"},
	{"jnlp", "application/x-java-jnlp-file"},
	{"jp2", "image/jp2"},
	{"jpe", "image/jpeg"},
	{"jpeg", "image/jpeg"},
	{"jpg", "image/jpeg"},
	{"js", "application/javascript"},
	{"kar", "audio/midi"},
	{"latex", "application/x-latex"},
	{"lha", "application/octet-stream"},
	{"lzh", "application/octet-stream"},
	{"m3u", "audio/x-mpegurl"},
	{"m4a", "audio/mp4a-latm"},
	{"m4b", "audio/mp4a-latm"},
	{"m4p", "audio/mp4a-latm"},
	{"m4u", "video/vnd.mpegurl"},
	{"m4v", "video/x-m4v"},
	{"mac", "image/x-macpaint"},
	{"md", "text/markdown"},
	{"man", "application/x-troff-man"},
	{"mathml", "application/mathml+xml"},
	{"me", "application/x-troff-me"},
	{"mesh", "model/mesh"},
	{"mid", "audio/midi"},
	{"midi", "audio/midi"},
	{"mif", "application/vnd.mif"},
	{"mov", "video/quicktime"},
	{"movie", "video/x-sgi-movie"},
	{"mp2", "audio/mpeg"},
	{"mp3", "audio/mpeg"},
	{"mp4", "video/mp4"},
	{"mpe", "video/mpeg"},
	{"mpeg", "video/mpeg"},
	{"mpg", "video/mpeg"},
	{"mpga", "audio/mpeg"},
	{"ms", "application/x-troff-ms"},
	{"msh", "model/mesh"},
	{"mxu", "video/vnd.mpegurl"},
	{"nc", "application/x-netcdf"},
	{"oda", "application/oda"},
	{"ogg", "application/ogg"},
	{"pbm", "image/x-portable-bitmap"},
	{"pct", "image/pict"},
	{"pdb", "chemical/x-pdb"},
	{"pdf", "application/pdf"},
	{"pgm", "image/x-portable-graymap"},
	{"pgn", "application/x-chess-pgn"},
	{"pic", "image/pict"},
	{"pict", "image/pict"},
	{"png", "image/png"},
	{"pnm", "image/x-portable-anymap"},
	{"pnt", "image/x-macpaint"},
	{"pntg", "image/x-macpaint"},
	{"ppm", "image/x-portable-pixmap"},
	{"ppt", "application/vnd.ms-powerpoint"},
	{"pptx","application/vnd.openxmlformats-officedocument.presentationml.presentation"},
	{"potx","application/vnd.openxmlformats-officedocument.presentationml.template"},
	{"ppsx","application/vnd.openxmlformats-officedocument.presentationml.slideshow"},
	{"ppam","application/vnd.ms-powerpoint.addin.macroEnabled.12"},
	{"pptm","application/vnd.ms-powerpoint.presentation.macroEnabled.12"},
	{"potm","application/vnd.ms-powerpoint.template.macroEnabled.12"},
	{"ppsm","application/vnd.ms-powerpoint.slideshow.macroEnabled.12"},
	{"ps", "application/postscript"},
	{"qt", "video/quicktime"},
	{"qti", "image/x-quicktime"},
	{"qtif", "image/x-quicktime"},
	{"ra", "audio/x-pn-realaudio"},
	{"ram", "audio/x-pn-realaudio"},
	{"ras", "image/x-cmu-raster"},
	{"rdf", "application/rdf+xml"},
	{"rgb", "image/x-rgb"},
	{"rm", "application/vnd.rn-realmedia"},
	{"roff", "application/x-troff"},
	{"rtf", "text/rtf"},
	{"rtx", "text/richtext"},
	{"sgm", "text/sgml"},
	{"sgml", "text/sgml"},
	{"sh", "application/x-sh"},
	{"shar", "application/x-shar"},
	{"silo", "model/mesh"},
	{"sit", "application/x-stuffit"},
	{"skd", "application/x-koan"},
	{"skm", "application/x-koan"},
	{"skp", "application/x-koan"},
	{"skt", "application/x-koan"},
	{"smi", "application/smil"},
	{"smil", "application/smil"},
	{"snd", "audio/basic"},
	{"so", "application/octet-stream"},
	{"spl", "application/x-futuresplash"},
	{"src", "application/x-wais-source"},
	{"sv4cpio", "application/x-sv4cpio"},
	{"sv4crc", "application/x-sv4crc"},
	{"svg", "image/svg+xml"},
	{"swf", "application/x-shockwave-flash"},
	{"t", "application/x-troff"},
	{"tar", "application/x-tar"},
	{"tcl", "application/x-tcl"},
	{"tex", "application/x-tex"},
	{"texi", "application/x-texinfo"},
	{"texinfo", "application/x-texinfo"},
	{"tif", "image/tiff"},
	{"tiff", "image/tiff"},
	{"tr", "application/x-troff"},
	{"tsv", "text/tab-separated-values"},
	{"txt", "text/plain"},
	{"ustar", "application/x-ustar"},
	{"vcd", "application/x-cdlink"},
	{"vrml", "model/vrml"},
	{"vxml", "application/voicexml+xml"},
	{"wav", "audio/x-wav"},
	{"wbmp", "image/vnd.wap.wbmp"},
	{"wbmxl", "application/vnd.wap.wbxml"},
	{"wml", "text/vnd.wap.wml"},
	{"wmlc", "application/vnd.wap.wmlc"},
	{"wmls", "text/vnd.wap.wmlscript"},
	{"wmlsc", "application/vnd.wap.wmlscriptc"},
	{"wrl", "model/vrml"},
	{"xbm", "image/x-xbitmap"},
	{"xht", "application/xhtml+xml"},
	{"xhtml", "application/xhtml+xml"},
	{"xls", "application/vnd.ms-excel"},
	{"xml", "application/xml"},
	{"xpm", "image/x-xpixmap"},
	{"xsl", "application/xml"},
	{"xlsx","application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
	{"xltx","application/vnd.openxmlformats-officedocument.spreadsheetml.template"},
	{"xlsm","application/vnd.ms-excel.sheet.macroEnabled.12"},
	{"xltm","application/vnd.ms-excel.template.macroEnabled.12"},
	{"xlam","application/vnd.ms-excel.addin.macroEnabled.12"},
	{"xlsb","application/vnd.ms-excel.sheet.binary.macroEnabled.12"},
	{"xslt", "application/xslt+xml"},
	{"xul", "application/vnd.mozilla.xul+xml"},
	{"xwd", "image/x-xwindowdump"},
	{"xyz", "chemical/x-xyz"},
	{"zip", "application/zip"}
  };
	}
}
