using FinanceApplication.Database;
using FinanceApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace FinanceApplication.Controllers
{
    public class AddEntityController : Controller
    {
        private readonly MVCdbdemo dbobj;
        public AddEntityController(MVCdbdemo dbobj)
        {
        this.dbobj=dbobj;
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
                return RedirectToAction("Add");

        }
    }
}
