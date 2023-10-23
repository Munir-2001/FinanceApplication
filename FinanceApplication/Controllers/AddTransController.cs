using Microsoft.AspNetCore.Mvc;

namespace FinanceApplication.Controllers
{
        private readonly MVCdbdemo dbobj;
        
    public class AddTransController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
         
    }
}
