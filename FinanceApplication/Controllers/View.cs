using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
