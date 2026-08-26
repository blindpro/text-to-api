using System.IO;
public static class Methods
{
public static string Text(string text)
{
return text;
}
public static string ReadFile(string path)
{
if(!File.Exists(path))
{
return "";
}
return File.ReadAllText(path);
}
}