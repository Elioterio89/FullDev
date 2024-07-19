using EstudoFull.Data.Converter.Implementations;
using EstudoFull.Data.Dto;
using EstudoFull.Models;
using EstudoFull.Models.Context;
using EstudoFull.Repository.Interfaces;
using EstudoFull.Services.Interfaces;
using System;
using System.Security.Cryptography;

namespace EstudoFull.Services
{

    public class PessoaService : IPessoaService
    {      
        private readonly IPessoaRepository _pessoaRepository;
        private readonly PessoaParse _parse;
        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
            _parse = new PessoaParse();          
        }

        public PessoaDto Criar(PessoaDto pPessoa)
        {
            var oPessoa = _parse.ParseDtoToEnt(pPessoa);
            oPessoa = _pessoaRepository.Criar(oPessoa);
            return _parse.ParseEntToDto(oPessoa);           
        }
        public List<PessoaDto> Listar()
        {
            return _parse.ListParseEntToDt( _pessoaRepository.Listar());
        }
        public PessoaDto BuscarPorId(long pId)
        {
            return _parse.ParseEntToDto( _pessoaRepository.BuscarPorId(pId));
        }

        public PessoaDto BuscarPorNome(string pNome)
        {
            return _parse.ParseEntToDto( _pessoaRepository.BuscarPorNome(pNome));
        }

        public PessoaDto Atualizar(PessoaDto pPessoa)
        {
            var oPessoa = _parse.ParseDtoToEnt(pPessoa);
            oPessoa = _pessoaRepository.Atualizar(oPessoa);
            return _parse.ParseEntToDto(oPessoa);
        }

        public bool Deletar(long pId)
        {
            return _pessoaRepository.Deletar(pId);
        }
    }
}
