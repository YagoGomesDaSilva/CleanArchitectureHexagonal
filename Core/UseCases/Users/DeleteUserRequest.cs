using Core.HTTP;

namespace Core.UseCases.Users;

public record DeleteUserRequest(string UserId) : Request(UserId);