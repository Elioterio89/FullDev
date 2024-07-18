using EstudoFull.Models;
using EstudoFull.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace EstudoFull.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {

        private readonly ILogger<PessoaController> _logger;
        private IPessoaService _pessoaService;

        public PessoaController(ILogger<PessoaController> logger, IPessoaService pessoaService)
        {
            _logger = logger;
            _pessoaService = pessoaService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            return Ok(_pessoaService.Listar());
        }

        [HttpGet("id/{pId}")]
        public IActionResult GetPorId(long pId)
        {
            var oPessoa = _pessoaService.BuscarPorId(pId);
            if (oPessoa == null)
            {
                return NotFound();
            }

            return Ok(oPessoa);
        }
        [HttpGet("nome/{pNome}")]
        public IActionResult GetPorNome(string pNome)
        {
            var oPessoa = _pessoaService.BuscarPorNome(pNome);
            if (oPessoa == null)
            {
                return NotFound();
            }
            return Ok(oPessoa);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pessoa pPessoa)
        {
            if (pPessoa == null)
            {
                return BadRequest();
            }
            return Ok(_pessoaService.Criar(pPessoa));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Pessoa pPessoa)
        {
            if (pPessoa == null)
            {
                return BadRequest();
            }
            return Ok(_pessoaService.Atualizar(pPessoa));
        }

        [HttpDelete("{pId}")]

        public IActionResult Delete(long pId)
        {
            var vDelete = _pessoaService.Deletar(pId);

            if (vDelete)
            {
                return Ok();
            }
            return BadRequest();
        }



    }
}
