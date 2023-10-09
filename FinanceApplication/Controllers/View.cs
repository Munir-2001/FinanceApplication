using Microsoft.AspNetCore.Mvc;

namespace FinanceApplication.Controllers
{
    public class View : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
