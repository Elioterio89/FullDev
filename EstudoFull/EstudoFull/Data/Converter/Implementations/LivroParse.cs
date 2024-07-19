using EstudoFull.Data.Converter.Contract;
using EstudoFull.Data.Dto;
using EstudoFull.Models;

namespace EstudoFull.Data.Converter.Implementations
{
    public class LivroParse : IParsser<LivroDto, Livro>
    {
        public List<Livro> ListParseDtoToEnt(List<LivroDto> Origens)
        {
            if (Origens != null)
            {
                return Origens.Select(p => ParseDtoToEnt(p)).ToList();
            }
            return null;
        }

        public List<LivroDto> ListParseEntToDt(List<Livro> Destinos)
        {
            if (Destinos != null)
            {
                return Destinos.Select(p => ParseEntToDto(p)).ToList();
            }
            return null;
        }

        public Livro ParseDtoToEnt(LivroDto Origem)
        {
            if (Origem != null)
            {
                return new Livro
                {
                    Id = Origem.Id,
                    Genero = Origem.Genero,
                    Autor  =    Origem.Autor,
                    Editora = Origem.Editora,
                    Titulo = Origem.Titulo 
                };
            }
            return null;
        }

        public LivroDto ParseEntToDto(Livro Destino)
        {
            if (Destino != null)
            {
                return new LivroDto
                {
                    Id = Destino.Id,
                    Genero = Destino.Genero,
                    Autor = Destino.Autor,
                    Editora = Destino.Editora,
                    Titulo = Destino.Titulo

                };
            }
            return null;
        }
    }
}
