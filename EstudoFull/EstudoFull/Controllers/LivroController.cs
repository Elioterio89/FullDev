﻿using Asp.Versioning;
using EstudoFull.Data.Dto;
using EstudoFull.Hypermedia.Filters;
using EstudoFull.Models;
using EstudoFull.Services;
using EstudoFull.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EstudoFull.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class LivroController : ControllerBase
    {
        private readonly ILogger<LivroController> _logger;
        private ILivroService _livroService;

        public LivroController(ILogger<LivroController> logger, ILivroService livroService)
        {
            _logger = logger;
            _livroService = livroService;
        }


        [HttpGet]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult GetAll()
        {
            return Ok(_livroService.Listar());
        }

        [HttpGet("id/{pId}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult GetPorId(long pId)
        {
            var oLivro = _livroService.BuscarPorId(pId);
            if (oLivro == null)
            {
                return NotFound();
            }

            return Ok(oLivro);
        }

        [HttpGet("titulo/{pTitulo}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult GetPorTitulo(string pTitulo)
        {
            var oLivro = _livroService.BuscarPorTitulo(pTitulo);
            if (oLivro == null)
            {
                return NotFound();
            }
            return Ok(oLivro);
        }

        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] LivroDto pLivro)
        {
            if (pLivro == null)
            {
                return BadRequest();
            }
            return Ok(_livroService.Criar(pLivro));
        }

        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] LivroDto pLivro)
        {
            if (pLivro == null)
            {
                return BadRequest();
            }
            return Ok(_livroService.Atualizar(pLivro));
        }

        [HttpDelete("{pId}")]
        public IActionResult Delete(long pId)
        {
            var vDelete = _livroService.Deletar(pId);

            if (vDelete)
            {
                return Ok();
            }
            return BadRequest();
        }

    }
}
