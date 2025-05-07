using Microsoft.AspNetCore.Mvc;
using xiangmu.Models;
using System.Linq;

namespace xiangmu.Controllers
{
    public class PositionController : Controller
    {
        private PayrollDBContext db = new PayrollDBContext();

        // 岗位信息查询页面
        public ActionResult query1()
        {
            var positions = db.Positions.ToList();
            return View(positions);
        }

        // 岗位列表维护页面
        public ActionResult Weihu()
        {
            return View();
        }
    }
}