using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FormTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FormController : ControllerBase
    {
        private readonly ILogger<FormController> _logger;

        public FormController(ILogger<FormController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Post([FromForm] FormModel formModel)
        {
            _logger.LogInformation("posted", formModel);
            return Ok();
        }
    }
}
