using EstudoFull.Models;

namespace EstudoFull.Repository.Interfaces
{
    public interface ILivroRepository : IAllRepository<Livro>
    {
        Livro BuscarPorTitulo(string pTitulo);
    }
}
