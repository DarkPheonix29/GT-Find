using Microsoft.AspNetCore.Mvc;

namespace GT_Web.Controllers
{
    public class FrontController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }
    }
}
