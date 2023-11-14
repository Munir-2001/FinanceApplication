using FinanceApplication.Database;
using FinanceApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace FinanceApplication.Controllers
{
    public class AddEntityController : Controller
    {
        public List<entity> searched {  get; set; }
        private readonly MVCdbdemo dbobj;
        public async Task<IActionResult> search() { 
        var str = Request.Form["searchstring"];
        searched=await dbobj.entities.Where(x=> x.FirstName.Contains(str)).ToListAsync();
        return View(searched);
        }
        public AddEntityController(MVCdbdemo dbobj)
        {
        this.dbobj=dbobj;
        }
        public async Task<IActionResult> Index(){
            var entities = await dbobj.entities.ToListAsync();
            return View(entities);

        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(entity entity)
        {
            var newentity = new entity()
            { 
                Id = Guid.NewGuid(),
                FirstName = entity.FirstName,
               LastName = entity.LastName,
                Description = entity.Description

            };
                await dbobj.AddAsync(newentity);
                await dbobj.SaveChangesAsync();
                return RedirectToAction("Index");

        }
    }
}
