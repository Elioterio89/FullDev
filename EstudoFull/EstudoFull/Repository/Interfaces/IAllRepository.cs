using EstudoFull.Models;

namespace EstudoFull.Repository.Interfaces
{
    public interface IAllRepository<T> where T : Base
    {
        T Criar(T pObjeto);
        T BuscarPorId(long pId);
        List<T> Listar();
        T Atualizar(T pObjeto);
        bool Deletar(long pId);
    }
}
