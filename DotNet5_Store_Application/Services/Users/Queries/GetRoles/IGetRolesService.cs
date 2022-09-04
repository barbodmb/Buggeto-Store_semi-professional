using DotNet5_Store_Common.Dto;
using System.Collections.Generic;

namespace DotNet5_Store_Application.Services.Users.Queries.GetRoles
{
    public interface IGetRolesService
    {
        ResultDto<List<RolesDto>> Execute();
    }
}