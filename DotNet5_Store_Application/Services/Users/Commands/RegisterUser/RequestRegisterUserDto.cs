using System.Collections.Generic;

namespace DotNet5_Store_Application.Services.Users.Commands.RegisterUser
{
    public class RequestRegisterUserDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public List<RoleInRegisterUserDto> roles { get; set; }
    }
}