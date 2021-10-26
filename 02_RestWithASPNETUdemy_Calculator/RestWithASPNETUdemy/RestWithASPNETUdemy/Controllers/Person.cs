using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Person : ControllerBase
    {


        private readonly ILogger<Person> _logger;

        public Person(ILogger<Person> logger)
        {
            _logger = logger;
        }


        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string firstNumber, string secondNumber)
        {

            return BadRequest("Invalid Input");
        }
    

        //[HttpGet("sub/{firstNumber}/{secondNumber}")]
        //public IActionResult sub(string firstNumber, string secondNumber)
        //{

        //    if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        //    {
        //        var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
        //        return Ok(sub.ToString());
        //    }

        //    return BadRequest("Invalid Input");
        //}

        //[HttpGet("div/{firstNumber}/{secondNumber}")]
        //public IActionResult div(string firstNumber, string secondNumber)
        //{

        //    if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        //    {
        //        var sub = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
        //        return Ok(sub.ToString());
        //    }

        //    return BadRequest("Invalid Input");
        //}

        //[HttpGet("mul/{firstNumber}/{secondNumber}")]
        //public IActionResult mul(string firstNumber, string secondNumber)
        //{

        //    if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        //    {
        //        var sub = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
        //        return Ok(sub.ToString());
        //    }

        //    return BadRequest("Invalid Input");
        //}

        //[HttpGet("med/{firstNumber}/{secondNumber}")]
        //public IActionResult med(string firstNumber, string secondNumber)
        //{

        //    if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        //    {
        //        var sub = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber))/2;
        //        return Ok(sub.ToString());
        //    }

        //    return BadRequest("Invalid Input");
        //}
        //[HttpGet("square-root/{firstNumber}")]
        //public IActionResult squareRoot(string firstNumber, string secondNumber)
        //{

        //    if (IsNumeric(firstNumber))
        //    {
        //        var squareRoot  = Math.Sqrt((double)ConvertToDecimal(firstNumber));
        //        return Ok(squareRoot.ToString());
        //    }

        //    return BadRequest("Invalid Input");
        //}
        //private bool IsNumeric(string strNumber)
        //{
        //    double number;
        //    bool isNumber = double.TryParse(
        //        strNumber, 
        //        System.Globalization.NumberStyles.Any,
        //        System.Globalization.NumberFormatInfo.InvariantInfo,
        //        out number);
        //        return isNumber;
        //    throw new NotImplementedException();
        //}

        //private decimal ConvertToDecimal(string strNumber)
        //{
        //    decimal decimalValue;
        //    if(decimal.TryParse(strNumber, out decimalValue))
        //    {
        //        return decimalValue;
        //    }
        //        return 0;
            
        }
    }
}
