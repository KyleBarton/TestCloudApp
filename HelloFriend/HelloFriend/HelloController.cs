using System.Web.Http;

namespace HelloFriend
{
    public class HelloController : ApiController
    {
        [Route("hello/world")]
        public IHttpActionResult Get()
        {
            return Ok("Hello World!");
        }
    }
}