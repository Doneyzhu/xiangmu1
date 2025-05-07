using Microsoft.AspNetCore.Mvc;

namespace xiangmu.Controllers
{
    public class LoginController : Controller
    {
        // 设定固定的用户名和密码
        private const string ValidUsername = "admin";
        private const string ValidPassword = "123456";

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            if (username == ValidUsername && password == ValidPassword)
            {
                // 登录成功，重定向到 query1 页面的 Index 方法
                return RedirectToAction("Index1", "Query1");
            }
            else
            {
                ViewBag.ErrorMessage = "用户名或密码错误";
                return View();
            }
        }
    }
}