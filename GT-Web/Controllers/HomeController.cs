using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GT_Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("HomeView");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
