using FinanceApplication.Database;
using FinanceApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;

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


        private List<entity> Getentity()
        {
            List<entity> ent = new List<entity>();
            foreach (entity entity in dbobj.entities)
            {
                ent.Add(entity);
            }
            return ent;

            
        }

        private List<domain> Getdomain()
        {
            List<domain> dom = new List<domain>();
            foreach(domain d in dbobj.domain)
            {
                dom.Add(d);
            }
            return dom;

        }
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to my demo!";
            dynamic mymodel = new ExpandoObject();
            mymodel.domain = Getdomain();
            mymodel.entities = Getentity();
            return View(mymodel);
        }





    }
    //public entitymodellists ViewModel { get; set; }
    /*public IActionResult Add()
    {
        return View();
    }*/

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
            return View();


          /*  entitymodellists e = new entitymodellists();
            e.entityview = new List<SelectListItem>();
            e.domainview = new List<SelectListItem>();
                
            var ent = dbobj.entities.ToList();
           // var dom = dbobj.domain.ToList();
            foreach(var item in ent)
            {
                e.entityview.Add(new SelectListItem {
                Text = item.FirstName + " " + item.LastName,
                    Value = Convert.ToString(item.Id)
                }); ;
            }*/
/*
            foreach (var item in dom) { 
            e.domainview.Add(new SelectListItem {
                Text = item.Name,
                Value = Convert.ToString(item.Id)
            });
            }*/


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

            }*/

            // Return the view with the ViewModel
/*            return View(e);
*/        

        /* public async Task OnGetAsync()
         {
             ViewModel = new entitymodellists
             {
                 entityview = await dbobj.entities.ToListAsync(),
                 domainview = await dbobj.domain.ToListAsync()
             };

         }*/
    //}
}
