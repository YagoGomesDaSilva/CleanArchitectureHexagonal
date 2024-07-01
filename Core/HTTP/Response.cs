using System.Text.Json.Serialization;

namespace Core.HTTP;

public class Response<TData>
{

    [JsonConstructor]
    public Response() { }

    [JsonConstructor]
    public Response(TData? data,string? message = null)
    {
        Data = data;
        Message = message;
    }

    public TData? Data { get; set; }
    public string? Message { get; set; }
}
