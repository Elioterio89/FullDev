using EstudoFull.Models;
using EstudoFull.Models.Context;
using EstudoFull.Services.Interfaces;
using System.Security.Cryptography;

namespace EstudoFull.Services
{

    public class PessoaService : IPessoaService
    {
        private MySQLContext _mySqlContext;
        public PessoaService(MySQLContext mySQLContext)
        {
            _mySqlContext = mySQLContext;
        }
      
        public Pessoa Criar(Pessoa pPessoa)
        {
            try
            {
                _mySqlContext.Add(pPessoa);
                _mySqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }

            return pPessoa;
        }
        public List<Pessoa> Listar()
        {

            return _mySqlContext.Pessoas.ToList();
        }
        public Pessoa BuscarPorId(long pId)
        {
            return _mySqlContext.Pessoas.FirstOrDefault(p=>p.Id.Equals(pId));
        }

        public Pessoa BuscarPorNome(string pNome)
        {
            return _mySqlContext.Pessoas.FirstOrDefault(p => p.PrimeiroNome.Equals(pNome));
        }

        public Pessoa Atualizar(Pessoa pPessoa)
        {
            var oPessoa = BuscarPorId(pPessoa.Id);
            if (oPessoa != null)
            {
                try
                {
                    _mySqlContext.Entry(oPessoa).CurrentValues.SetValues(pPessoa);
                    _mySqlContext.SaveChanges();

                }
                catch (Exception)
                {
                    throw;
                }
                return pPessoa;
            }
            else
            {
                return Criar(pPessoa);
            }

        }

        public bool Deletar(long pId)
        {
            var oPessoa = BuscarPorId(pId);
            if (oPessoa != null)
            {
                try
                {
                    _mySqlContext.Remove(oPessoa);
                    var teste =  _mySqlContext.SaveChanges();
                    return true;
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
            return false;
        }

 

    }
}
