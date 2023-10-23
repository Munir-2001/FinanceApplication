using FinanceApplication.Database;
using FinanceApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinanceApplication.Controllers
{
    public class AddDomainController : Controller
    {
        public List<domain> searched { get; set; }
        private readonly MVCdbdemo dbobj;
        public async Task<IActionResult> search()
        {
            var str = Request.Form["searchdomain"];
            searched = await dbobj.domain.Where(x => x.Name.Contains(str)).ToListAsync();
            return View(searched);
        }
        public AddDomainController(MVCdbdemo dbobj)
        {
            this.dbobj = dbobj;
        }
        public IActionResult Add()
        {
            return View();
        }
        public async Task<IActionResult> Index()
        {
            var domains = await dbobj.domain.ToListAsync();
            return View(domains);
        }
        [HttpPost]
        public async Task<IActionResult> Add(domain domain) {
            var d = new domain() {
                Id = Guid.NewGuid(),
                Name = domain.Name   
            };
            await dbobj.AddAsync(d);
            await dbobj.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
