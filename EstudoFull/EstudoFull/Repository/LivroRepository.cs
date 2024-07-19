using EstudoFull.Models;
using EstudoFull.Models.Context;
using EstudoFull.Repository.Interfaces;
using System.Security.Cryptography;

namespace EstudoFull.Repository
{
    public class LivroRepository : AllRepository<Livro> ,ILivroRepository 
    {
        public LivroRepository(MySQLContext mySQLContext) : base(mySQLContext)
        {
        }

        public Livro BuscarPorTitulo(string pTitulo)
        {
            try
            {
                var oLivro = _mySQLcontext.Livros.FirstOrDefault(p => p.Titulo.Equals(pTitulo));
                if (oLivro != null)
                {
                    return oLivro;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return null;
        }

    }
}
