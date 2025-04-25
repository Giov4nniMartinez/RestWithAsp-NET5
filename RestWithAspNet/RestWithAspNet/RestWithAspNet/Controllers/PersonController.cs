using Microsoft.AspNetCore.Mvc;

namespace RestWithAspNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
         private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{fristNumber}/{secondNumber}")]
        public IActionResult sum( string fristNumber, string secondNumber)
        {
            if (IsNumeric(fristNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(fristNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());            
            }
            return BadRequest("Invalid Input");
        }

    }
}
