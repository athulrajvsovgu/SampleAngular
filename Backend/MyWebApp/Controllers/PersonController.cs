using DatabaseAccess;
using System.Linq;
using System.Web.Http;

namespace MyWebApp.Controllers
{
    [RoutePrefix("api/users")]
    public class PersonController : ApiController
    {
        [Route("")]
        public IHttpActionResult GetAllPersons()
        {
            var context = new TrainingDatabase();
            var persons = context.AR_Person.ToArray();
            return Ok(persons);
        }

        [Route("{id}")]
        public IHttpActionResult GetPersonById(int id)
        {
            var context = new TrainingDatabase();
            var person = context.AR_Person.FirstOrDefault(p => p.id == id);
            return Ok(person);
        }
    }
}
