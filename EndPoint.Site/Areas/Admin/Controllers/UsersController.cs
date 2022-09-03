using DotNet5_Store_Application.Services.Users.Queries.GetUsers;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly IGetUsersService _getUsersService;
        public UsersController(IGetUsersService getUsersService)
        {
            _getUsersService = getUsersService;
        }

        public IActionResult Index(string searchKey, int page = 1)
        {
            return View(_getUsersService.Execute(new RequestGetUseDto
            {
                SearchKey = searchKey,
                Page = page
            }));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}