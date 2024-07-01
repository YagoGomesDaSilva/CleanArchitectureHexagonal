using Core.HTTP;

namespace Core.UseCases.Users;

public record GetUserByIdRequest(string UserId) : Request(UserId);