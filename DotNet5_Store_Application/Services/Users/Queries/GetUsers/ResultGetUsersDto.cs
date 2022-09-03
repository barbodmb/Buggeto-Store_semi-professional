using System.Collections.Generic;

namespace DotNet5_Store_Application.Services.Users.Queries.GetUsers
{
    public class ResultGetUsersDto
    {
        public List<GetUsersDto> Users { get; set; }
        public int Rows { get; set; }
    }
}