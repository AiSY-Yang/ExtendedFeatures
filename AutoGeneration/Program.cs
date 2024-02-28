// See https://aka.ms/new-console-template for more information
using System.Text;

var path = "../../../../ExtendedFeatures/System";
var filePath = "../../../../README.md";
var lines = File.ReadAllLines(filePath);
StringBuilder stringBuilder = new StringBuilder();
var enumerator = lines.AsEnumerable().GetEnumerator();
//开始部分
while (enumerator.MoveNext())
{
	if (enumerator.Current == "# File")
	{
		stringBuilder.AppendLine(enumerator.Current);
		enumerator.MoveNext();
		stringBuilder.AppendLine(enumerator.Current);
		break;
	}
	else
		stringBuilder.AppendLine(enumerator.Current);
}
//获取文件树
var tree = GetTree(path, true, "*.cs");
foreach (var item in tree)
{ stringBuilder.AppendLine(item); }
while (enumerator.MoveNext())
{
	if (enumerator.Current == "```")
	{
		stringBuilder.AppendLine("```");
		break;
	}
}
//结束部分
while (enumerator.MoveNext())
{
	stringBuilder.AppendLine(enumerator.Current);
}

File.WriteAllText(filePath, stringBuilder.ToString());
Console.WriteLine("更新完成");




List<string> GetTree(string path, bool ignoreEmptyDir, string searchPattern = "*")
{
	var res = new List<string>();
	res.Add(Path.GetFileName(path));
	res.AddRange(GetChild(path, "", ignoreEmptyDir, searchPattern));
	return res;
}
List<string> GetChild(string dir, string prefix, bool ignoreEmptyDir, string searchPattern = "*")
{
	var res = new List<string>();
	var dirs = Directory.GetDirectories(dir);
	var files = Directory.GetFiles(dir, searchPattern);
	for (var i = 0; i < dirs.Length; i++)
	{

		if (ignoreEmptyDir && Directory.GetFiles(dirs[i], searchPattern, SearchOption.AllDirectories).Length == 0) continue;
		string s = prefix;
		var lineEnd = i == dirs.Length - 1 && files.Length == 0;
		s += lineEnd ? "└─" : "├─";
		s += Path.GetFileName(dirs[i]);
		res.Add(s);
		res.AddRange(GetChild(dirs[i], prefix + (lineEnd ? "  " : "| "), ignoreEmptyDir, searchPattern));
	}
	for (var i = 0; i < files.Length; i++)
	{
		string s = prefix;
		if (i == files.Length - 1)
			s += "└─";
		else
			s += "├─";
		s += Path.GetFileName(files[i]);
		res.Add(s);
	}
	return res;
}