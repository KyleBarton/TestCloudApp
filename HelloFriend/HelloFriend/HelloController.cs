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

        [Route("hello/v2/{name}")]
        public IHttpActionResult Get(string name)
        {
            return Ok($"Hello, {name}");
        }
    }
}