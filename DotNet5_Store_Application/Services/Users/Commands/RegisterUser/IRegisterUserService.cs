using DotNet5_Store.Domain.Entities.Users;
using DotNet5_Store_Application.Interfaces.Contexts;
using DotNet5_Store_Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet5_Store_Application.Services.Users.Commands.RegisterUser
{
    public interface IRegisterUserService
    {
        ResultDto<ResultRegisterUserDto> Execute(RequestRegisterUserDto request);
    }

    public class RegisterUserService : IRegisterUserService
    {
        private IDatabaseContext _context;
        public RegisterUserService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultRegisterUserDto> Execute(RequestRegisterUserDto request)
        {
            User user = new User()
            {
                Email = request.Email,
                FullName = request.FullName
            };
            List<UserInRoll> userInRolls = new List<UserInRoll>();
            foreach (var item in request.roles)
            {
                var rols = _context.Roles.Find(item.Id);
                userInRolls.Add(new UserInRoll
                {
                    Role = rols,
                    RoleId = rols.Id,
                    User = user,
                    UserId = user.Id
                });
            }
            user.UserInRoll = userInRolls;
            _context.Users.Add(user);
            _context.SaveChanges();
            return new ResultDto<ResultRegisterUserDto>()
            {
                Data = new ResultRegisterUserDto()
                {
                    UserId = user.Id
                },
                IsSuccess = true,
                Message = "ثبت نام کاربر انجام شد"
            };
        }
    }

    public class RequestRegisterUserDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public List<RoleInRegisterUserDto> roles { get; set; }
    }

    public class ResultRegisterUserDto
    {
        public long UserId { get; set; }
    }

    public class RoleInRegisterUserDto
    {
        public long Id { get; set; }
    }
}