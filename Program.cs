using System.Collections.Generic;
class Program
{
public static int Main(string[] args)
{
Setup.Start();
bool parsed = Parser.ParseFile();
if(!parsed)
{
Console.WriteLine("failed to load api.txt! Please create your api.txt file containing the data.");
return 1;
}
if(Database.GetSize() <1)
{
Console.WriteLine("Error! Your api.txt has no valid values!.");
return 1;
}
Console.WriteLine("api.txt data loaded.");
Console.WriteLine("api.txt contains "+Database.GetSize()+" values");
var data = Database.Data;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
foreach(ApiData value in data)
{
string type = value.RequestType;
if(type == "get")
{
app.MapGet(value.Endpoint, () =>value.Value);
}
else if(type == "post")
{
app.MapPost(value.Endpoint, () =>"value");
}
}
app.MapGet("/", () => "Hello World!");
app.Run();
return 0;
}
}