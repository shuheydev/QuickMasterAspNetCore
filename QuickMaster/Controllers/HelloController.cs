using Microsoft.AspNetCore.Mvc;

namespace QuickMaster.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello, world");
        }

        public IActionResult Greet()
        {
            ViewBag.Message = "Hello,World!";

            //テンプレートを呼び出す
            return View();
        }
    }
}