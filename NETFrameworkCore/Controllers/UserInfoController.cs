using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NETFrameworkCore.Controllers
{
    public class UserInfoController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
