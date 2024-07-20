using Microsoft.AspNetCore.Mvc;
namespace APITesting.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SumController : ControllerBase
{
    [HttpGet("add")]
    public IActionResult Add([FromQuery] int a, [FromQuery] int b)
    {
        var result = a + b;
        return Ok(new { Sum = result });
    }
}