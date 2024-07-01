using System.Text.Json.Serialization;

namespace Core.HTTP;

public class PagedResponse<TData> : Response<TData>
{
    [JsonConstructor]
    public PagedResponse(TData? data,int totalCount,int currentPage = 1,int pageSize = Configuration.DefaultPageSize) : base(data)
    {
        Data = data;
        TotalCount = totalCount;
        CurrentPage = currentPage;
        PageSize = pageSize;
    }

    public PagedResponse(TData? data, string? message = null) : base(data, message)
    {
    }

    public int CurrentPage { get; set; }
    public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
    public int PageSize { get; set; } = Configuration.DefaultPageSize;
    public int TotalCount { get; set; }
}