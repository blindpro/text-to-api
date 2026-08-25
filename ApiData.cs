public class ApiData
{
public string RequestType {get; private set;}
public string Endpoint {get; private set;}
public string Method {get; private set;}
public string Value {get; private set;}
public ApiData(string RequestType, string Endpoint, string Method, string Value)
{
this.Endpoint = Endpoint;
this.RequestType = RequestType;
this.Method = Method;
this.Value = Value;
}

}