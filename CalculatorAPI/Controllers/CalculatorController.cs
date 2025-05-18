using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("Add/{num1}/{num2}")]
        public decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        [HttpGet("Subtract/{num1}/{num2}")]
        public decimal Subtract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        [HttpGet("Multiply/{num1}/{num2}")]
        public decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        [HttpGet("Divide/{num1}/{num2}")]
        public decimal Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }

        [HttpGet("Modulo/{num1}/{num2}")]
        public decimal Modulo(decimal num1, decimal num2)
        {
            return num1 % num2;
        }
    }
}