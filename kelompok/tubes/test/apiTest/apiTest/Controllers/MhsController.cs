using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MhsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetMhs()
        {
            var result = new List<string> { "value1", "value2" };
            return Ok(result);
        }


    }
}
