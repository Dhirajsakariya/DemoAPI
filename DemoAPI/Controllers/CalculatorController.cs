using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Cors;

namespace DemoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        [Route("/add")]

        public int Add(int num1, int num2)
        {
            var sum = num1 + num2;
            _logger.LogInformation($"Addition of {num1} and {num2} is {sum}");
            return sum;
        }
    }
}
