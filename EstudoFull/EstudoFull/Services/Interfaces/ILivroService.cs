using EstudoFull.Data.Dto;
using EstudoFull.Models;

namespace EstudoFull.Services.Interfaces
{
    public interface ILivroService 
    {
        LivroDto BuscarPorTitulo(string pTitulo);
        LivroDto Criar(LivroDto pLivro);
        List<LivroDto> Listar();
        LivroDto BuscarPorId(long pId);
        LivroDto Atualizar(LivroDto pLivro);
        bool Deletar(long pId);
    }
}
