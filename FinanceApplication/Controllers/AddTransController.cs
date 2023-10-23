using Microsoft.AspNetCore.Mvc;

namespace FinanceApplication.Controllers
{
    public class AddTransController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
