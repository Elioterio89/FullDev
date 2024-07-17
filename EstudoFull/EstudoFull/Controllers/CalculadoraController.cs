using Microsoft.AspNetCore.Mvc;

namespace EstudoFull.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {

        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        [HttpGet("soma/{nUm}/{nDois}")]
        public IActionResult GetSoma(string nUm, string nDois)
        {
            if (ehNumero(nUm) && ehNumero(nDois))
            {
                var soma = ConvertDecimal(nUm) + ConvertDecimal(nDois);
                return Ok(soma.ToString());
            }
            return BadRequest("Entrada invalida");
        }

        [HttpGet("sub/{nUm}/{nDois}")]
        public IActionResult GetSub(string nUm, string nDois)
        {
            if (ehNumero(nUm) && ehNumero(nDois))
            {
                var soma = ConvertDecimal(nUm) - ConvertDecimal(nDois);
                return Ok(soma.ToString());
            }
            return BadRequest("Entrada invalida");
        }

        [HttpGet("mult/{nUm}/{nDois}")]
        public IActionResult GetMult(string nUm, string nDois)
        {
            if (ehNumero(nUm) && ehNumero(nDois))
            {
                var soma = ConvertDecimal(nUm) * ConvertDecimal(nDois);
                return Ok(soma.ToString());
            }
            return BadRequest("Entrada invalida");
        }

        [HttpGet("div/{nUm}/{nDois}")]
        public IActionResult GetDiv(string nUm, string nDois)
        {
            if (ehNumero(nUm) && ehNumero(nDois))
            {
                var soma = ConvertDecimal(nUm) / ConvertDecimal(nDois);
                return Ok(soma.ToString());
            }
            return BadRequest("Entrada invalida");
        }

        private decimal ConvertDecimal(string numero)
        {
            decimal num;
            if (decimal.TryParse(numero,out num))
            {
                return num;
            }
           return 0;
        }

        private bool ehNumero(string numero)
        {
            double num;
            bool ehNumero = double.TryParse
                        (numero, 
                        System.Globalization.NumberStyles.Any, 
                        System.Globalization.NumberFormatInfo.InvariantInfo, 
                        out num);
            return ehNumero;
        }
    }
}
