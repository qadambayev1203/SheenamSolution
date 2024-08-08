//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use Comfort and Peace
//==================================================

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
