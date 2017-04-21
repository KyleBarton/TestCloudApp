using System.Web.Http;

namespace HelloFriend
{
    public class HelloController : ApiController
    {
        [HttpGet]
        [Route("hello/world")]
        public IHttpActionResult Get()
        {
            return Ok("Hello World!");
        }

        [HttpGet]
        [Route("hello/v2/{name}")]
        public IHttpActionResult Get(string name)
        {
            return Ok($"Hello, {name}");
        }

        [HttpGet]
        [Route("insult/{name}")]
        public IHttpActionResult Insult(string name)
        {
            return Ok($"You're ugly, {name}!");
        }
    }
}