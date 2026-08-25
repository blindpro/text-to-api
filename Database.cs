using System.Collections.Generic;
public static class Database
{
public static List<ApiData> Data {get; private set;} = new();
public static int 	GetSize()
{
return Data.Count;
}
public static void add(ApiData data)
{
Data.Add(data);
}
}