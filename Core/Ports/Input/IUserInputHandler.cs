using Core.Domain.Entities;
using Core.HTTP;
using Core.UseCases.Users;

namespace Core.Ports.Input;

public interface IUserInputHandler
{
    Task<Response<User?>> CreateAsync(CreateUserRequest request);
    Task<Response<User?>> UpdateAsync(UpdateUserRequest request);
    Task<Response<User?>> DeleteAsync(DeleteUserRequest request);
    Task<Response<User?>> GetByIdAsync(GetUserByIdRequest request);
    Task<PagedResponse<List<User>?>> GetAllAsync(GetAllUserRequest request);
}