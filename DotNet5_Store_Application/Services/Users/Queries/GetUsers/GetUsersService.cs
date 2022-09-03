using DotNet5_Store_Application.Interfaces.Contexts;
using DotNet5_Store_Common;
using System.Linq;

namespace DotNet5_Store_Application.Services.Users.Queries.GetUsers
{
    public class GetUsersService : IGetUsersService
    {
        private readonly IDatabaseContext _context;
        public GetUsersService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultGetUsersDto Execute(RequestGetUseDto request)
        {
            var users = _context.Users.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.SearchKey))
            {
                users = users.Where(p => p.FullName.Contains(request.SearchKey) || p.Email.Contains(request.SearchKey));
            }
            int rowsCount = 0;
            var userList = users.ToPaged(request.Page, 20, out rowsCount).Select(p => new GetUsersDto
            {
                Email = p.Email,
                FullName = p.FullName,
                Id = p.Id
            }).ToList();

            return new ResultGetUsersDto
            {
                Rows = rowsCount,
                Users = userList
            };
        }
    }
}