using Microsoft.AspNetCore.Mvc;

namespace KurentoDemo.Controllers.API
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Room()
        {
            return View();
        }
    }
}
