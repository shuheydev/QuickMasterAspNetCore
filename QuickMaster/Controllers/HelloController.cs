using Microsoft.AspNetCore.Mvc;
using QuickMaster.Models;

namespace QuickMaster.Controllers
{
    public class HelloController : Controller
    {
        private readonly MyContext _context;
        private readonly MyContext2 _context2;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context">DIで渡される</param>
        public HelloController(MyContext context, MyContext2 context2)
        {
            this._context = context;
            this._context2 = context2;
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