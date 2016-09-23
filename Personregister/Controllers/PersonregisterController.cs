using Personregister.Models;
using Personregister.PersonServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Personregister.Controllers
{
    [RoutePrefix("api/personregister")]
    public class PersonregisterController : ApiController
    {
        private PersonModel _personModel;
        public PersonModel PersonModel {
            get {
                if (_personModel == null)
                {
                    _personModel = new PersonModel();
                }
                return _personModel;
            }
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Index()
        {
            return Ok("Index");
        }

        [Route("{id:int}")]
        public IHttpActionResult GetPersonByNIN(string NIN)
        {
            var person = PersonModel.GetPerson(NIN);

            if(person == null)
            {
                return NotFound();
            }

            return Ok(person) ;
        }
    }
}
