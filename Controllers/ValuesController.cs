using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginWithJWTToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // Public API - এখানে টোকেন লাগবে না
        [HttpGet("public")]
        public IActionResult PublicData()
        {
            return Ok(new { message = "This is public data, no token required." });
        }

        // Private API - এখানে টোকেন লাগবে
        [Authorize]
        [HttpGet("private")]
        public IActionResult PrivateData()
        {
            return Ok(new { message = "This is private data, valid token required!" });
        }
    }
}
