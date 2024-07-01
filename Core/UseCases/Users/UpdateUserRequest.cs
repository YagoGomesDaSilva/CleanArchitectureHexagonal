using Core.Domain.Entities;
using Core.HTTP;

namespace Core.UseCases.Users;

public record UpdateUserRequest(
     string UserId,
     string? DataString,
     int DataInt,
     decimal DataDecimal,
     DateTime DataDateTime,
     Obj_1? Obj_1
 ) : Request(UserId);