using System.IO;
public static class Parser
{
public static bool ParseFile()
{
if(!File.Exists("api.txt"))
{
return false;
}
foreach(string line in File.ReadLines("api.txt"))
{
string[] parts = line.Split(":",StringSplitOptions.RemoveEmptyEntries);
if(parts.Length<4 || ! Database.HasMethod(parts[2]))
{
continue;
}
var data = new ApiData(parts[0],parts[1],parts[2],parts[3]);
Database.add(data);
}
return true;
}
}