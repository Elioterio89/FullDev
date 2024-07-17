using EstudoFull.Models;

namespace EstudoFull.Services.Interfaces
{
    public interface IPessoaService
    {
        Pessoa Criar(Pessoa pPessoa);
        Pessoa BuscarPorId(long pId);
        Pessoa BuscarPorNome(string pNome);
        List<Pessoa> Listar();
        Pessoa Atualizar (Pessoa pPessoa);
        bool Deletar(long pId);


    }
}
