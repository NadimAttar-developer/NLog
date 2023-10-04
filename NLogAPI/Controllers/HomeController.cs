using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace NLogAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    //private readonly ILogger<HomeController> _logger;

    Logger _logger = LogManager.GetLogger("NadimLogger");

    [HttpGet]
    public IActionResult Index()
    {
        try
        {
            _logger.Info("Hello, I'm Nadim Attar I'm working as a Software Engineer");

            int x = 0;
            int y = 1;
            int z = y / x;

            return StatusCode(200);
        }
        catch (Exception ex)
        {
            _logger.Error(ex.Message);

            return StatusCode(500);
        }
    }

}
