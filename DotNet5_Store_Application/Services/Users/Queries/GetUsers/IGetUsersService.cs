using System.Collections.Generic;

namespace DotNet5_Store_Application.Services.Users.Queries.GetUsers
{
    public interface IGetUsersService
    {
        ResultGetUsersDto Execute(RequestGetUseDto request);
    }
}