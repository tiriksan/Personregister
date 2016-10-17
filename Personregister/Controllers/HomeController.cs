using Personregister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Personregister.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPerson(string NIN)
        {
            if(NIN.Length == 11)
            {
                PersonModel model = new PersonModel();
                var person = model.GetPerson(NIN);
                var json = model.ConvertPersonToJSON(person);
                return Content(json);
            }
            
            return View();
        }
    }
}