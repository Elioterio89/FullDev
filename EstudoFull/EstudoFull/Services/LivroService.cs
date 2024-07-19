using EstudoFull.Data.Converter.Implementations;
using EstudoFull.Data.Dto;
using EstudoFull.Models;
using EstudoFull.Repository;
using EstudoFull.Repository.Interfaces;
using EstudoFull.Services.Interfaces;

namespace EstudoFull.Services
{
    public class LivroService : ILivroService
    {
        private ILivroRepository _livroRepository;
        private readonly LivroParse _parse;
        public LivroService(ILivroRepository livroRepository)
        { 
            _livroRepository = livroRepository;
            _parse = new LivroParse();
        }
        public LivroDto Atualizar(LivroDto pLivro)
        {
            var oLivro = _parse.ParseDtoToEnt(pLivro);
            oLivro = _livroRepository.Atualizar(oLivro);
            return _parse.ParseEntToDto(oLivro);
        }

        public LivroDto BuscarPorId(long pId)
        {
            return _parse.ParseEntToDto(_livroRepository.BuscarPorId(pId));
        }

        public LivroDto BuscarPorTitulo(string pTitulo)
        {
            return _parse.ParseEntToDto(_livroRepository.BuscarPorTitulo(pTitulo));
        }

        public LivroDto Criar(LivroDto pLivro)
        {
            var oLivro = _parse.ParseDtoToEnt(pLivro);
            oLivro = _livroRepository.Criar(oLivro);
            return _parse.ParseEntToDto(oLivro);
        }

        public bool Deletar(long pId)
        {
            return _livroRepository.Deletar(pId);
        }

        public List<LivroDto> Listar()
        {
            return _parse.ListParseEntToDt(_livroRepository.Listar());
        }
    }
}
