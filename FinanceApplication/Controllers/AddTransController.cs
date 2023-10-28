using FinanceApplication.Database;
using FinanceApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinanceApplication.Controllers
{
    public class AddTransController : Controller
    {
        private readonly MVCdbdemo dbobj;
        public AddTransController(MVCdbdemo dbobj)
        {
            this.dbobj = dbobj;
        }
        /*public IActionResult Add()
        {
            return View();
        }*/
        public entitymodellists ViewModel { get; set; }

        /*public async Task<IActionResult> Add()
        {
            ViewModel = new entitymodellists
                {
                    entityview = await dbobj.entities.ToListAsync(),
                    domainview = await dbobj.domain.ToListAsync()
                };

            
            return View(ViewModel);
        }*/
        public IActionResult Add()
        {
            // Your logic to fetch data and perform other operations
            var ent = new entitymodellists
            {
                entityview = dbobj.entities.ToList(),
                domainview = dbobj.domain.ToList()
            };
            Console.WriteLine(ent.entityview[0].FirstName);
            Console.WriteLine(ent.domainview[0].Name);


            // Return the view with the ViewModel
            return View("Add", ent);
        }

        /* public async Task OnGetAsync()
         {
             ViewModel = new entitymodellists
             {
                 entityview = await dbobj.entities.ToListAsync(),
                 domainview = await dbobj.domain.ToListAsync()
             };

         }*/
    }
}
