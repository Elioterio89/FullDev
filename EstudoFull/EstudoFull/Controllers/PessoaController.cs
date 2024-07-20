using Asp.Versioning;
using EstudoFull.Data.Dto;
using EstudoFull.Hypermedia.Filters;
using EstudoFull.Models;
using EstudoFull.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace EstudoFull.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
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
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult GetAll()
        {

            return Ok(_pessoaService.Listar());
        }

        [HttpGet("id/{pId}")]
        [TypeFilter(typeof(HyperMediaFilter))]
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
        [TypeFilter(typeof(HyperMediaFilter))]
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
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] PessoaDto pPessoa)
        {
            if (pPessoa == null)
            {
                return BadRequest();
            }
            return Ok(_pessoaService.Criar(pPessoa));
        }

        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] PessoaDto pPessoa)
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
