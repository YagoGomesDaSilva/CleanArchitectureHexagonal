namespace Core.HTTP;

public record PagedRequest(int PageSize = Configuration.DefaultPageSize, int PageNumber = Configuration.DefaultPageNumber, string UserId = "") 
    : Request(UserId);