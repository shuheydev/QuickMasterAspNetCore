using Microsoft.AspNetCore.Mvc;
using QuickMaster.Models;

namespace QuickMaster.Controllers
{
    public class HelloController : Controller
    {
        private readonly MyContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context">DIで渡される</param>
        public HelloController(MyContext context)
        {
            this._context = context;
        }

        public IActionResult List()
        {
            return View(this._context.Book);
        }

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