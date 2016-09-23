using Personregister.Models;
using Personregister.PersonServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Personregister.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            PersonModel personModel = new PersonModel();
            
            return View();
        }
    }
}