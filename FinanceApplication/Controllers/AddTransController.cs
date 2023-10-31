using FinanceApplication.Database;
using FinanceApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FinanceApplication.Controllers
{
    public class AddTransController : Controller
    {
        protected readonly MVCdbdemo dbobj;
        public List<transaction> searched { get; set; }
        public async Task<IActionResult> search()
        {
            var str = Request.Form["searchtransaction"];
            searched = await dbobj.transaction.Where(x => x.ent.Contains(str)).ToListAsync();
            return View(searched);
        }
        public AddTransController(MVCdbdemo dbobj)
        {
            this.dbobj = dbobj;
        }

        /*public async List<SelectListItem> getall()
        {
            var domains = await dbobj.domain.ToListAsync();
            
            foreach (var evmodel in domains)
            {
                    evmodel.Id = domains.Al;
            }

           
            return domains;
        }*/

        //public entitymodellists ViewModel { get; set; }


        public async Task<IActionResult> Index()
        {
            var transactions = await dbobj.transaction.ToListAsync();
            return View(transactions);

        }


        [HttpGet]
        public async Task<IActionResult> Add()
          {
            EntityDomainViewModel v = new EntityDomainViewModel
            {
                entitylist = await dbobj.entities.ToListAsync(),
                domainlist = await dbobj.domain.ToListAsync(),
            };

              return View(v);
          }

        [HttpPost]
        public async Task<IActionResult> newAdd(EntityDomainViewModel e)
        {

            var newtrans = new transaction()
            {
                Id = Guid.NewGuid(),
                dom =e.t.dom,
                ent = e.t.ent,
                tratype = e.t.tratype,
                amount=e.t.amount,
                dt = DateTime.Now
            };

            await dbobj.AddAsync(newtrans);
            await dbobj.SaveChangesAsync();


            return RedirectToAction("Index");

        }
        /*        public IActionResult Add()
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
        */
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
