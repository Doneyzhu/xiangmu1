using Microsoft.AspNetCore.Mvc;

namespace xiangmu.Controllers
{
    public class WeihuController : Controller
    {
        public IActionResult Index()
        {
            return View("weihu");
        }
    }
}