using System.Collections.Generic;
public static class Database
{
public static List<ApiData> Data {get; private set;} = new();
public static Dictionary<string,Func<string, string>> Methods {get; private set;} = new();
public static int 	GetSize()
{
return Data.Count;
}
public static void add(ApiData data)
{
Data.Add(data);
}
public static void AddMethod(string name, Func<string,string> method)
    {
Methods[name] = method;
    }
public static bool HasMethod(string name)
    {
return Methods.ContainsKey(name);
}
}