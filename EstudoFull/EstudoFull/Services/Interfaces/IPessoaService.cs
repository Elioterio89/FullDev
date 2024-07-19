using EstudoFull.Data.Dto;
using EstudoFull.Models;

namespace EstudoFull.Services.Interfaces
{
    public interface IPessoaService 
    {
        PessoaDto BuscarPorNome(string pNome);
        PessoaDto Criar(PessoaDto pPessoa);
        List<PessoaDto> Listar();
        PessoaDto BuscarPorId(long pId);
        PessoaDto Atualizar(PessoaDto pPessoa);
        bool Deletar(long pId);

    }
}
