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
        public List<entity> eselect { get; set; }
        public List<domain> dselect { get; set; }

        private readonly MVCdbdemo dbobj;
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
   /* public IActionResult Add()
    {
        return View();
    }
*/
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

                    
            // Your logic to fetch data and perform other operations
            /*var ent = new List<entity>();
            {
                ent = dbobj.entities.ToList();
            };
            var dom = new List<domain>();
            {
                dom = dbobj.domain.ToList();
            };*/
            /*if (ent != null )
            {
                *//*            Console.WriteLine(ent.entityview[0].FirstName);
                *//*
                Console.WriteLine(e.domainview.Count);

                Console.WriteLine(e.entityview.Count);


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
