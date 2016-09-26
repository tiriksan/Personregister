using Personregister.Models;
using System.Web.Http;

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
        [Route("{id}")]
        public string GetPersonByNIN(string id)
        {
            var person = PersonModel.GetPerson(id);

            if (person == null)
            {
                return "";
            }

            var jsonPerson = PersonModel.ConvertPersonToJSON(person);

            return jsonPerson;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Index()
        {
            return Ok("Index");
        }



        
    }
}
