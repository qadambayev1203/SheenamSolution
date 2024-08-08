using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Sheenam.Api.Controllers
{
    [Route("api/home-controller")]
    [ApiController]
    public class HomeController : RESTFulController
    {
        [HttpGet("get")]
        public ActionResult<string> Get() => Ok("Hello Dear!");
    }
}
