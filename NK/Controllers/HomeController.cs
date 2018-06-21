using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NK.Models;

namespace NK.Controllers
{
    public class HomeController : Controller
    {

     
        public ActionResult Index()
        {
            NK18ViewModel vm = new NK18ViewModel();
            
            using (NK_18_Context db = new NK_18_Context())
            {
                // vm.ListaTopKupacaNK18 = new List<NK18>(db.NK17.ToList());

                vm.ListaTopKupacaNK18 = new List<NK18>(db.NK18.ToList());

            }

            return View(vm);
        }

      


        

    }
}