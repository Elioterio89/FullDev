using EstudoFull.Models;
using EstudoFull.Models.Context;
using EstudoFull.Repository.Interfaces;
using System.Security.Cryptography;

namespace EstudoFull.Repository
{
    public class PessoaRepository : AllRepository<Pessoa>, IPessoaRepository
    {
      
        public PessoaRepository(MySQLContext mySQLContext) : base(mySQLContext)
        {
        }
       
        public Pessoa BuscarPorNome(string pNome)
        {
            try
            {
                var oPessoa = _mySQLcontext.Pessoas.FirstOrDefault(p => p.PrimeiroNome.Equals(pNome));
                if (oPessoa != null)
                {
                    return oPessoa;
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
