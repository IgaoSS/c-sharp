using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public abstract class MyFirstApiBaseController : ControllerBase
{
    [HttpGet("Healthy")]
    public IActionResult Healthy()
    {
        return Ok("Ok");
    }
    protected string GetRandomKey()
    {
        return Request.Headers["MyKey"].ToString();
    }
}
