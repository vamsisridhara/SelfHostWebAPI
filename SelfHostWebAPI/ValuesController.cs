using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostWebAPI
{
 
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        [ValidateModelStateFilter]
        [HttpGet()]
        [Route("all")]
        public IHttpActionResult Get()
        {
            return Ok("I am alive");
        }

        [ValidateModelStateFilter]
        [HttpPost()]
        [Route("insertUser")]
        public IHttpActionResult PostUser([FromBody] User user)
        {
            return Ok("I am alive");
        }

        [ValidateModelStateFilter]
        [HttpPost()]
        [Route("insertPerson")]
        public IHttpActionResult PostPerson([FromBody] Person person)
        {
            return Ok("I am alive");
        }
    }
}
