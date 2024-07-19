using EstudoFull.Models;

namespace EstudoFull.Repository.Interfaces
{
    public interface IPessoaRepository : IAllRepository<Pessoa>
    {       
        Pessoa BuscarPorNome(string pNome);
    }
}
