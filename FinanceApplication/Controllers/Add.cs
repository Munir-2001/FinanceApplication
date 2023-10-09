using Microsoft.AspNetCore.Mvc;

namespace FinanceApplication.Controllers
{
    public class Add : Controller
    {
        public IActionResult addindex()
        {
            return View();
        }

        public IActionResult addtrans() 
        { return View(); }

        public IActionResult domain()
        { return View(); }


        public IActionResult entity()
        { return View(); }
    }
}
