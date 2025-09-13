using Microsoft.AspNetCore.Mvc;

namespace Middleware.WebAPI.Controller;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet]
    public IActionResult Method(string name)
    {
        throw new ArgumentException("bla bla");
        return Ok();
    }
}
