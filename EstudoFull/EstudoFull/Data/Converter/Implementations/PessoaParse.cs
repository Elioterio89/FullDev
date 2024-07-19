using EstudoFull.Data.Converter.Contract;
using EstudoFull.Data.Dto;
using EstudoFull.Models;

namespace EstudoFull.Data.Converter.Implementations
{
    public class PessoaParse : IParsser<PessoaDto, Pessoa>
    {
        public List<Pessoa> ListParseDtoToEnt(List<PessoaDto> Origens)
        {
            if(Origens != null)
            {
                return Origens.Select(p => ParseDtoToEnt(p)).ToList();
            }
            return null;
        }

        public List<PessoaDto> ListParseEntToDt(List<Pessoa> Destinos)
        {
            if (Destinos != null)
            {
                return Destinos.Select(p => ParseEntToDto(p)).ToList();
            }
            return null;
        }

        public Pessoa ParseDtoToEnt(PessoaDto Origem)
        {
            if (Origem != null)
            {
               return  new Pessoa
                {
                    Id = Origem.Id,
                    Endereco = Origem.Endereco,
                    Genero = Origem.Genero,
                    PrimeiroNome = Origem.PrimeiroNome,
                    Sobrenome = Origem.Sobrenome
                };
            }
            return null;
        }

        public PessoaDto ParseEntToDto(Pessoa Destino)
        {
            if (Destino != null)
            {
                return new PessoaDto
                {
                    Id = Destino.Id,
                    Endereco = Destino.Endereco,
                    Genero = Destino.Genero,
                    PrimeiroNome = Destino.PrimeiroNome,
                    Sobrenome = Destino.Sobrenome
                };
            }
            return null;
        }
    }
}
