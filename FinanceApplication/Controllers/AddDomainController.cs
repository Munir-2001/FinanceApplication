using Microsoft.AspNetCore.Mvc;

namespace FinanceApplication.Controllers
{
    public class AddDomainController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
