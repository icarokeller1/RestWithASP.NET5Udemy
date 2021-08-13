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
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{operacao}/{firstnumber}/{secondnumber}")]
        public IActionResult Get(string operacao, string firstnumber, string secondnumber)
        {
            string resultado;
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                switch (operacao)
                {
                    case "soma":
                        resultado = (Convert.ToDecimal(firstnumber) + Convert.ToDecimal(secondnumber)).ToString();
                        return Ok(resultado);

                    case "sub":
                        resultado = (Convert.ToDecimal(firstnumber) - Convert.ToDecimal(secondnumber)).ToString();
                        return Ok(resultado);

                    case "mult":
                        resultado = (Convert.ToDecimal(firstnumber) * Convert.ToDecimal(secondnumber)).ToString();
                        return Ok(resultado);

                    case "div":
                        resultado = (Convert.ToDecimal(firstnumber) / Convert.ToDecimal(secondnumber)).ToString();
                        return Ok(resultado);

                    case "media":
                        resultado = ((Convert.ToDecimal(firstnumber) + Convert.ToDecimal(secondnumber))/2).ToString();
                        return Ok(resultado);

                    case "pot":
                        resultado = Math.Pow(Convert.ToDouble(firstnumber), Convert.ToDouble(secondnumber)).ToString();
                        return Ok(secondnumber);
                }
            }

            return BadRequest("Invalid Input");
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            return double.TryParse(strNumber, out number);
        }
    }

}
