using FinanceApplication.Database;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApplication.Controllers
{
    public class Add : Controller
    {
        private readonly MVCdbdemo mvcdb;
        public IActionResult addindex()
        {
            return View("addindex");
        }

        public IActionResult addtrans() 
        { return View(); }

        public IActionResult domain()
        { return View(); }


        public IActionResult entity()
        { return View(); }
    }
}
